﻿using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyserProblem2
{
    public class MoodAnalysisException : Exception
    {

        public enum ExceptionType { EMPTY, NULL, NO_SUCH_METHOD, NO_SUCH_CLASS, NO_SUCH_FIELD }

        public readonly ExceptionType type;
        public MoodAnalysisException( ExceptionType type,string message): base(message)
        {
           this.type = type;
        }
    }
}
