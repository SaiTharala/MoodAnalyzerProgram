using System;
using System.Collections.Generic;
using System.Text;

namespace MoodAnalyzerTesting
{
    class MoodAnalyzerTest
    {
        string message;
        public MoodAnalyzerTest(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
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