using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem2
{
    public class MoodAnalysisException : Exception
    {

        public enum ExceptionType { EMPTY, NULL }

        public readonly ExceptionType type;
        public MoodAnalysisException(ExceptionType type, string message): base(message)
        {
            this.type = type;
        }
    }
}
