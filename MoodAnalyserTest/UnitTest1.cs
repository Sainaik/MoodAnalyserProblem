using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem2;


namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood_ShouldReturn_Sad()
        {
            //Arraneg
            string message = "I am in Sad Mood";

            string expected = "Sad";

            MoodAnalyser obj = new MoodAnalyser();

            //Act
            string actual =obj.AnalyseMood(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }


        [TestMethod]
        public void AnalyseMood_ShouldReturn_Happy()
        {
            //Arraneg
            string message = "I am in Any Mood";

            string expected = "Happy";

            MoodAnalyser obj = new MoodAnalyser();

            //Act
            string actual = obj.AnalyseMood(message);

            //Assert
            Assert.AreEqual(expected, actual);

        }
    }
}
