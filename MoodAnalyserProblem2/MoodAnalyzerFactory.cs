using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using System.Text.RegularExpressions;

namespace MoodAnalyserProblem2
{
    public class MoodAnalyzerFactory
    {

        public static Object CreateMoodAnalyse(string className, string constructorName)
        {
            String pattern = @"." + constructorName + "$";
            Regex regex = new Regex(pattern);

            if (regex.IsMatch(className))
            {

                try
                {
                    Assembly executing = Assembly.GetExecutingAssembly();
                    Type moodAnalyseType = executing.GetType(className);
                    return Activator.CreateInstance(moodAnalyseType);

                }
                catch (ArgumentNullException)
                {
                    throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_CLASS, "Class is not found");

                }
            }
            else
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NO_SUCH_METHOD, "Constuctor is not found");

            }


        }

       
    }

}
