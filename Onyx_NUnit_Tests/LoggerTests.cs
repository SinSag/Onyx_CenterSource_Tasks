using Onyx_ConsoleApp.Models;

namespace Onyc_Tests
{
    public class LoggerTests
    { 
        [Test]
        public void Log()
        {
            //arrange
            var logger = new Logger(@"enter filepath here");
            //act
            logger.Log("test");
            logger.Close_Writer();
            //assert
            Assert.Pass();
        }

        [Test]
        public void Log_Test_Correct_DateTime_Prefix()
        {
            //arrange
            string datetime = string.Format("[{0:dd.MM.yy HH:mm:ss}]", DateTime.Now);
            //act
            string lastLine = File.ReadLines(@"C:\Users\Sindr\Skrivebord\test.txt").Last();
            //assert;
            Assert.That(lastLine, Does.StartWith(datetime));
        }
    }
}