using System;
using System.Collections.Generic;

namespace LogProcessingApp
{
    public class logMessage
    {
        public System.Guid Id { get; set; }
        public Nullable<System.DateTime> DateMessage { get; set; }
        public string Type { get; set; }
        public string Subsystem { get; set; }
        public string Message { get; set; }
    }
}