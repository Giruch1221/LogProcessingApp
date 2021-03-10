using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LogProcessingApp
{
    public partial class Form1 : Form
    {
        CancellationTokenSource _tokenSource;
        logMessageContext context;
        Regex rgx;
        static Regex rgxStatic = new Regex(@"^(?<Date>((0?0[1-9]|[12][0-9]|3[01])[\.](0?0[1-9]|1[012])[\.]((19|20)\d\d)) (0[0-9]|1[0-9]|2[0-3]):[0-5][0-9]:[0-5][0-9].[0-9][0-9][0-9]) (?<Type>[W|I|D|E]) (?<SubSystem>[A-Za-z0-9]+) ", RegexOptions.Compiled);

        /// <summary>
        /// Допустим, что при входе в приложение таблица с логами должна быть пустой . Но из-за этого будет открываться медленно, тк первое обращение через ef долгое
        /// </summary>
        public Form1()
        {
            InitializeComponent();
            context = new logMessageContext();
            context.Database.ExecuteSqlCommand("TRUNCATE TABLE [logMessages]");
        }

        /// <summary>
        /// Обработчик нажатия кнопки "Начать Экспорт"
        /// Запускаем ассинхронный экспорт документа. Допустим расширение файла txt или log
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private async void ExportBtn_Click(object sender, EventArgs e)
        {
            OpenFileDialog fileDialog = new OpenFileDialog();
            fileDialog.Title = "Выберете файл для экспорта";
            fileDialog.Filter = "(*.txt)|*.txt|(*.log)|*.log";
            if (fileDialog.ShowDialog() == DialogResult.Cancel)
                return;        
            ExportBtn.Enabled = false;
            CancelExportBtn.Enabled = true;
            _tokenSource = new CancellationTokenSource();
            CancellationToken cancelToken = _tokenSource.Token;
            ExportState.Text = "Данные экспортируются в БД, ожидайте";
            try
            {
                await Task.Run(() => ImportLogToDB(cancelToken , fileDialog.FileName), cancelToken);
                if (!_tokenSource.IsCancellationRequested)
                {
                    ExportState.Text = "Данные экспортированы. Загружено: " + Environment.NewLine;
                    DisplayExportStatistic();
                }
            }
            catch (Exception ex)
            {
                ExportState.Text = $"Выберите другой файл. Во время экспорта произошла ошибка: {ex.Message}";
            }            
            ExportBtn.Enabled = true;
            CancelExportBtn.Enabled = false;
        }

        /// <summary>
        /// Обработка строк выбранного файла. Допустим кодировку знаем заранее и это utf-8
        /// </summary>
        /// <param name="cancelToken"></param>
        /// <param name="fileName"> имя выбранного файла</param>
        private void ImportLogToDB(CancellationToken cancelToken , string fileName)
        {

            context.Database.ExecuteSqlCommand("TRUNCATE TABLE [logMessages]");
            using (var file = new FileStream(fileName, FileMode.Open, FileAccess.Read, FileShare.ReadWrite))
            using (var reader = new StreamReader(file, Encoding.UTF8))
            {              
                string line;
                string logItem = default;
                while ((line = reader.ReadLine()) != null && (!_tokenSource.IsCancellationRequested))  // обрабатываем до тех пор, пока не закончится файл или не отменили экспорт
                {

                    var isNewLogItem = rgxStatic.IsMatch(line);   // проверяем подходит ли строка под маску записи лога
                    if (isNewLogItem) 
                    {
                         if (!String.IsNullOrEmpty(logItem)) //Если появилась новая строка, соответствующая маске, добавляем предыдущую в таблицу
                         {
                             LogItemAddToDB(logItem);
                             logItem = "";
                         }
                         logItem += line ;
                      
                    }
                    else if ((!String.IsNullOrEmpty(logItem)) && (!isNewLogItem))  // если строка не соответсвует маске, то считаем, что это часть Сообщения 
                    {
                        logItem += "\n" + line;
                    } 
                    else throw new Exception("Лог содержит некорректные строки"); // лог начинается со строки не соответствующей маске, выбрасываем исключение
                }
                if (!String.IsNullOrEmpty(logItem)) // Добавляем последнюю запись лога в таблицу
                {
                    LogItemAddToDB(logItem);
                    logItem = "";
                }
            }

        }

        /// <summary>
        /// Обработчки кнопки "Отменить".Отменяем экспорт
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void CancelExport_Click(object sender, EventArgs e)
        {
            _tokenSource.Cancel();
            ExportBtn.Enabled = true;
            CancelExportBtn.Enabled = false;
            ExportState.Text = $"Данные загружены неполностью. Экспорт был отменен. Загружено:"+ Environment.NewLine;
            DisplayExportStatistic();

        }

        /// <summary>
        /// Добавление записи лога в таблицу
        /// </summary>
        /// <param name="logItem"> запись лога</param>

        private void LogItemAddToDB(string logItem) 
        {           
            var match = rgxStatic.Match(logItem);
            SqlParameter id = new SqlParameter("id", Guid.NewGuid());
            SqlParameter Message = new SqlParameter("Message", logItem.Remove(0, match.Groups[0].Value.Length));
            SqlParameter DateMessage = new SqlParameter("DateMessage", DateTime.Parse(match.Groups["Date"].Value));
            SqlParameter Type = new SqlParameter("Type", match.Groups["Type"].Value);
            SqlParameter Subsystem = new SqlParameter("Subsystem", match.Groups["SubSystem"].Value);
            context.Database.ExecuteSqlCommand("INSERT INTO [dbo].[logMessages] ([Id],DateMessage,Type,Subsystem, [Message] ) VALUES (@id, @DateMessage, @Type ,@Subsystem,@Message)", id, DateMessage, Type, Subsystem, Message);

        }

        /// <summary>
        /// После завершения экспорта или при отмене, выводим статистику экспорта
        /// </summary>
        private void DisplayExportStatistic()
        {
            var query = context.logMessages
                       .GroupBy(p => p.Type)
                       .Select(g => new { name = g.Key, count = g.Count() });
            int all = 0;
            foreach (var item in query)
            {
                all += item.count;
                ExportState.Text += "Тип " + item.name + " Количество" + item.count + Environment.NewLine;
            }
            ExportState.Text += "Общее количество " + all;
        }

        /// <summary>
        /// Поиск сообщений по параметрам
        /// Допустим, если не выбран ни один checkBox (типы) или пустой textBoxSystem (Система) , считаем, что по ним не фильтруем
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void SearchBtn_Click(object sender, EventArgs e)
        {

            var filteredData = context.logMessages.Select(x => new { x.DateMessage, x.Type, x.Subsystem, x.Message }).Where(n => n.DateMessage >= dateTimePickerFrom.Value && n.DateMessage <= dateTimePickerTo.Value);
            if (checkBoxI.Checked || checkBoxD.Checked || checkBoxE.Checked || checkBoxW.Checked)
            {
                filteredData = filteredData.Where(n =>((checkBoxI.Checked) && n.Type == "I") 
                    || ((checkBoxD.Checked) && n.Type == "D")
                    || ((checkBoxE.Checked) && n.Type == "E")
                    || ((checkBoxW.Checked) && n.Type == "W"));
            }
            if (!String.IsNullOrWhiteSpace(textBoxSystem.Text)) 
            {
                filteredData = filteredData.Where(n => n.Subsystem == textBoxSystem.Text);
            }        
            logGridView.DataSource = filteredData.ToList(); 
        }
    }
}
