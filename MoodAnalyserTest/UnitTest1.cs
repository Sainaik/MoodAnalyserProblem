using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem2;


namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood_ShouldReturn_Happy_givenNULL()
        {
            //Arraneg
            string message = null;

            string expected = "Happy";

            MoodAnalyser obj = new MoodAnalyser(message);

            //Act
            string actual =obj.AnalyseMood();

            //Assert
            Assert.AreEqual(expected, actual);

        }

    }
}
