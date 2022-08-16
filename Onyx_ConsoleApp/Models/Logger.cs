//logger class

namespace Onyx_ConsoleApp.Models
{
    public class Logger
    {
        private readonly StreamWriter _writer;

        //constructor
        public Logger(string path)
        {
            _writer = StartWriter(path);

            Log("Logger initialized");
        }

        //creates an instance of StreamWriter
        public StreamWriter StartWriter(string path)
        {
            var writer = new StreamWriter(File.Open(path, FileMode.Append))
            {
                AutoFlush = true
            };

            return writer;
        }

        //logs the string parameter
        public void Log(string str)
        {
            var date = GetDateTime();
            _writer.WriteLine(date + " " + str);
        }

        //gets the current date and time
        public string GetDateTime()
        {
            return string.Format("[{0:dd.MM.yy HH:mm:ss}]", DateTime.Now);
        }

        //closes the instance of StreamWriter
        public void CloseWriter()
        {
            _writer.Close();
        }
    }
}