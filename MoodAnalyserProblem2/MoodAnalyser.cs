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
                if (message.Contains("Sad"))
                {
                    return "Sad";
                }
                else
                {
                    return "Happy";
                }
            }
            catch
            {
                return "Happy";
            }
        }

    }
}
