using System;

namespace MoodAnalyserProblem2
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to Mood Analyser Problem!!");
            MoodAnalyser mood = new MoodAnalyser(null);
            try {
                mood.AnalyseMood();
            }catch(Exception e)
            {
                Console.WriteLine(e);
            }
        }
    }
}
