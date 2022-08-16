using Onyx_ConsoleApp.Models;

namespace Onyx_Tests
{
    public class LoggerTests
    {
        [Test]
        public void Log_Test_Correct_DateTime_Prefix()
        {
            Logger logger = new Logger(@"C:\Users\Sindr\Skrivebord\test.txt");

            logger.CloseWriter();

            string lastLine = File.ReadLines(@"C:\Users\Sindr\Skrivebord\test.txt").Last();

            string dateTimeNow = string.Format("[{0:dd.MM.yy HH:mm:ss}]", DateTime.Now);

            Assert.That(lastLine, Does.StartWith(dateTimeNow));
        }
    }
}