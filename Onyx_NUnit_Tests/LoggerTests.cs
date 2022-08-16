using Onyx_ConsoleApp.Models;

namespace Onyx_Tests
{
    public class LoggerTests
    {
        [Test]
        public void Log_Test_Correct_DateTime_Prefix()
        {
            //enter your desired filepath
            Logger logger = new Logger(@"enter your desired filepath here");

            logger.CloseWriter();
            //enter your desired filepath
            string lastLine = File.ReadLines(@"enter your desired filepath here").Last();

            string dateTimeNow = string.Format("[{0:dd.MM.yy HH:mm:ss}]", DateTime.Now);

            Assert.That(lastLine, Does.StartWith(dateTimeNow));
        }
    }
}