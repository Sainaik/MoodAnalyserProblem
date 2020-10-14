using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem2;


namespace MoodAnalyserTest
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void AnalyseMood_givenNULL_ShouldReturn_CustomExceptionTypeNULL()
        {
            
            string expected = "Mood should not be NULL";

            try
            {
                string message = null;
                MoodAnalyser obj = new MoodAnalyser(message);
                string actual = obj.AnalyseMood();

            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }



        [TestMethod]
        public void AnalyseMood_givenEmpty_ShouldReturn_CustomExceptionTypeEmpty()
        {

            string expected = "Mood should not be empty";

            try
            {
                string message = string.Empty;
                MoodAnalyser obj = new MoodAnalyser(message);
                string actual = obj.AnalyseMood();

            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }


        [TestMethod]
        public void AnalyseMood_ShouldReturn_CustomExceptionTypeEmpty_givenSad()
        {
            string expected = "Sad";
            try
            {
                string message = "They are Sad";
                MoodAnalyser obj = new MoodAnalyser(message);
                string actual = obj.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

        [TestMethod]
        public void AnalyseMood_ShouldReturn_CustomExceptionTypeEmpty_givenHappy()
        {
            string expected = "Happy";
            try
            {
                string message = "He is always Happy";
                MoodAnalyser obj = new MoodAnalyser(message);
                string actual = obj.AnalyseMood();
                Assert.AreEqual(expected, actual);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

        [TestMethod]
        public void GivenMoodAnalyseClass_ShouldReturn_MoodAnalyserObject()
        {
            string message = null;

            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserProblem2.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }


    }

}

