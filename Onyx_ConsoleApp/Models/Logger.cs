//imports necessary libraries
using System;
using System.IO;

namespace Onyx_ConsoleApp.Models
{
    public class Logger
    {
        private readonly StreamWriter _writer;

        public Logger(string path)
        {
            _writer = new StreamWriter(File.Open(path, FileMode.Append))
            {
                AutoFlush = true
            };

            Log("Logger initialized");
        }

        public void Log(string str)
        {
            _writer.WriteLine(string.Format("[{0:dd.MM.yy HH:mm:ss}] {1}", DateTime.Now, str));
        }

        public void Close_Writer()
        {
            _writer.Close();
        }
    }
}