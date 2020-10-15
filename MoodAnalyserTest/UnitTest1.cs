using Microsoft.VisualStudio.TestPlatform.TestHost;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using MoodAnalyserProblem2;
using System;

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

        //Test Case 5.1
        [TestMethod]
        [DataRow(null)]
        [DataRow("Happy")]
        public void GivenMoodAnalyseClass_ShouldReturn_MoodAnalyserObject_UsingParameterizedConstrucor(string message)
        {

            object expected = new MoodAnalyser(message);
            object obj = MoodAnalyzerFactory.CreateMoodAnalyserUsingParameterisedConstructors("MoodAnalyserProblem2.MoodAnalyser", "MoodAnalyser", message);
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
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserUsingParameterisedConstructors(wrongClassName, "MoodAnalyzer",message);
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
                object obj = MoodAnalyzerFactory.CreateMoodAnalyserUsingParameterisedConstructors("MoodAnalyserProblem2.MoodAnalyser", wrongConstructorName,message);
                moodAnalyser.Equals(obj);
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

        //UC 6.1 & 6.2
        [DataRow("Happy","Happy")]
        [DataRow("Sad", "Sad")]
        [TestMethod]

        public void MoodAnalyserFactory_ToInvokeMethod(string message, string expected)
        {
            try
            {
                string methodName = "AnalyseMood";
                string actual = MoodAnalyzerFactory.InvokeAnalyseMoodMethodUsingReflection(message,methodName);
                Assert.AreEqual(expected, actual);
            }catch(MoodAnalysisException e)
            {
                Console.WriteLine(e.Message);
            }
        }

        //UC7
        // tc 7.1
        [TestMethod]
        public void GivenMessageDynamically_returnMessage()
        {
            string expected = "Iam so happy";

            string actual = MoodAnalyzerFactory.MoodAnalysersSetField("Iam so happy", "message");
            Assert.AreEqual(expected, actual);
        }

        // tc 7.2
        [TestMethod]
        public void GivenImproperFieldName_ThrowNoSuchFieldException()
        {

           string expected = "Field not found";
            try
            {
                MoodAnalyzerFactory.MoodAnalysersSetField("Iam so happy", "wrongMessage");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

        // tc 7.3

        [TestMethod]
        public void GivenNullMessage_ThrowException()
        {
            string expected = "Mood should not be NULL"; 

            try
            {
                MoodAnalyzerFactory.MoodAnalysersSetField(null, "message");
            }
            catch (MoodAnalysisException e)
            {
                Assert.AreEqual(expected, e.Message);
            }

        }

    }

}

