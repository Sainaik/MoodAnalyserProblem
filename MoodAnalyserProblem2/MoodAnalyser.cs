using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem2
{
 
 
    public class MoodAnalyser
    {
        public string message;

        public MoodAnalyser()
        {
            
        }
        public MoodAnalyser(string message)
        {
            this.message = message;
        }

        public string AnalyseMood()
        {
            try
            { 
            if ((this.message.Equals(string.Empty)))
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.EMPTY, "Message should not be empty");
            }
            else
            {
                if (this.message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            
            }catch(NullReferenceException)
            {
                throw new MoodAnalysisException(MoodAnalysisException.ExceptionType.NULL, "Message should not be NULL");
            }

            
         
        }

    }
}
