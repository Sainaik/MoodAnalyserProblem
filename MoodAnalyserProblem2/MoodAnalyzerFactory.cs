using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem2
{
    public class MoodAnalyzerFactory
    {
        // UC4
        public static Object CreateMoodAnalyse(string className, string constructorName)
        {
            String pattern = @"." + constructorName + "$";
            //Regex regex = new Regex(pattern);
            Match result = Regex.Match(className, pattern);

            if (result.Success)
            {

                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();

                    //Get type of object from loaded assembly
                    Type moodAnalyseType = executing.GetType(className);

                    return Activator.CreateInstance(moodAnalyseType);

                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class not found");

                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constructor not found");

            }


        }

        //UC5
        public static Object CreateMoodAnalyserUsingParameterisedConstructors(string className, string constructorName)
        {
            Type type = typeof(MoodAnalyser);

            if (type.Name.Equals(className) || type.FullName.Equals(className))
            {

                if (type.Name.Equals(constructorName))
                {
                    ConstructorInfo ctor = type.GetConstructor(new[] { typeof(string) });
                    Object instance = ctor.Invoke(new object[] { "Happy" });
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

    }
}
