namespace LogProcessingApp
{
    using System;
    using System.Data.Entity;
    using System.Linq;

    public class logMessageContext : DbContext
    {
      
        
        public logMessageContext()
            : base("name=logMessageModel")
        {
        }


        public virtual DbSet<logMessage> logMessages { get; set; }
    }


}