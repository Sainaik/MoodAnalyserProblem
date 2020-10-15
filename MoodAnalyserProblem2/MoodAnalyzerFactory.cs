using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem2
{
    public class MoodAnalyzerFactory
    {
        /// <summary>
        /// UC5
        /// Creating a MoodAnalyser object with parameterised constructor using Reflection
        /// </summary>
        /// <param name="className"></param>
        /// <param name="constructorName"></param>
        /// <param name="message"></param>
        /// <returns></returns>
        //UC5

        public static Object CreateMoodAnalyserUsingParameterisedConstructors(string className, string constructorName, string message)
        {
            Type type = typeof(MoodAnalyser);

            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {

                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo constructorObject = type.GetConstructor(new[] { typeof(string) });
                    Object instance = constructorObject.Invoke(new object[] { message });
                    return instance;
                }
                else
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");
                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");

            }
        }

      /// <summary>
      /// UC6 
      /// Invoking AnalyseMoodMethod Using Reflection 
      /// called in UnitTest1.cs 
      /// </summary>
      /// <param name="message"></param>
      /// <param name="methodName"></param>
      /// <returns></returns>
      
        public static string InvokeAnalyseMoodMethodUsingReflection(string message, string methodName)
        {
            try
            {

                Type type = Type.GetType("MoodAnalyserProblem2.MoodAnalyser");

                Object moodAnalyserObject = MoodAnalyzerFactory.CreateMoodAnalyserUsingParameterisedConstructors(type.FullName, type.Name, message);

                MethodInfo method = type.GetMethod(methodName);

                string actualMessage =(string) method.Invoke(moodAnalyserObject, null);

                //object instance = method.Invoke(moodAnalyserObject, null);
                return actualMessage;

            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Method not found");
            }
        }

        public static string MoodAnalysersSetField(string message, string fieldName)
        {
            try
            {
                if (message == null)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL, "Mood should not be NULL");
                }

                MoodAnalyser obj = new MoodAnalyser();

                Type type = Type.GetType("MoodAnalyserProblem2.MoodAnalyser");

                FieldInfo field = type.GetField(fieldName);

                field.SetValue(obj, message);

                return obj.message;
            }
            catch (NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_FIELD, "Field not found");
            }

        }


    }
}
