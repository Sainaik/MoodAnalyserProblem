using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem2
{
    public class MoodAnalyser
    {
        public MoodAnalyser()
        {

        }

        public string AnalyseMood(string message)
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

    }
}
