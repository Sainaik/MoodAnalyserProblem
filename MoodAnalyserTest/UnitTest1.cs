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
        //Test case 4.1
        [TestMethod]
        public void GivenMoodAnalyseClass_ShouldReturn_MoodAnalyserObject()
        {
            string message = null;
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserProblem2.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        //Test case 4.2
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongClassName_ShouldReturn_NoClassException()
        {
            string expected = "Class not found";
            try
            {
                string message = null;
                string wrongClassName = "MoodAnalyserProblem2.MoodAnalyzer";
                object moodAnalyser = new MoodAnalyser(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse(wrongClassName, "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

        //Test case 4.3
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongConstructorName_ShouldReturn_NoConstructorException()
        {
            string expected = "Constructor not found";
            try
            {
                string message = null;
                string wrongConstructorName = "MoodAnalyzer";
                object moodAnalyser = new MoodAnalyser(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyse("MoodAnalyserProblem2.MoodAnalyser", wrongConstructorName);
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

        //Test Case 5.1
        [TestMethod]
        public void GivenMoodAnalyseClass_ShouldReturn_MoodAnalyserObject_UsingParameterizedConstrucor()
        {
            string message = "Happy";
            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyserUsingParameterisedConstructors("MoodAnalyserProblem2.MoodAnalyser", "MoodAnalyser");
            expected.Equals(obj);
        }

        //Test Case 5.2
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongClassName_ShouldReturn_NoClassException_UsingParameterizedConstrucor()
        {
            string expected = "Class not found";
            try
            {
                string message = "Happy";
                string wrongClassName = "MoodAnalyserProblem2.MoodAnalyzer";
                object moodAnalyser = new MoodAnalyser(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserUsingParameterisedConstructors(wrongClassName, "MoodAnalyzer");
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

        //Test case 5.3
        [TestMethod]
        public void MoodAnalyseClass_GivenWrongConstructorName_ShouldReturn_NoConstructorException_UsingParameterizedConstrucor()
        {
            string expected = "Constructor not found";
            try
            {
                string message = "Happy";
                string wrongConstructorName = "MoodAnalyzer";
                object moodAnalyser = new MoodAnalyser(message);
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserUsingParameterisedConstructors("MoodAnalyserProblem2.MoodAnalyser", wrongConstructorName);
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }


    }

}

