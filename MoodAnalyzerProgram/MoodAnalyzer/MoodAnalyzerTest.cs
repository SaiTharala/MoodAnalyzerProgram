using System;

namespace MoodAnalyzer
{
    public class MoodAnalyzerTest
    {
        string message;
        public MoodAnalyzerTest(string message)
        {
            this.message = message;
        }
        public string AnalyzeMood()
        {
            try
            {
                if (message.Contains("Sad"))
                    return "Sad";
                else
                    return "Happy";
            }
            catch (NullReferenceException)
            {
                return "Happy";
            }
        }
    }
}
