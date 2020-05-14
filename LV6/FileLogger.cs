using System;
using System.Collections.Generic;
using System.Text;

namespace LV6
{
    class FileLogger : AbstractLogger
    {
        private string filePath;

        public FileLogger(MessageType messageType, string filePath) : base(messageType)
        {
            this.filePath = filePath;
        }

        protected override void WriteMessage(string message, MessageType type)
        {
            System.Text.StringBuilder strBuilder = new System.Text.StringBuilder();
            strBuilder.Append(type + ": " + DateTime.Now);
            strBuilder.Append('>', message.Length);
            strBuilder.Append(message);
            strBuilder.Append(('=', message.Length) + "\n"); 
            Console.WriteLine(strBuilder);
        }
    }
}
