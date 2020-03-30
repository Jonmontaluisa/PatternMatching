using System;
using System.Collections.Generic;
using PatternMatching.MatchingEngine;
using PatternMatching.DataProcesor;

namespace PatternMatching
{
    public  class MatchingCenter
    {
        static bool readFromFile = true;
        static string BayerMooreAlgorithm = "BayerMooreAlgorithm";
        static string KMPAlgorithm = "KMPAlgorithm";
        static void Main(string[] args)
        {

            DataReader dataReader = new DataReader(readFromFile);
            List<string> data = dataReader.readTextAndPattern(args);
            string text = data[0];
            string pattern = data[1];
            text = text.ToLower();
            pattern = pattern.ToLower();
            Engine engine = new Engine(KMPAlgorithm);
            List<int> indexes = engine.indexes(text, pattern);
            Console.WriteLine("[{0}]", string.Join(", ", indexes));
        }
    }
}
 