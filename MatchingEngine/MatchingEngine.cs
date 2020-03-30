using System;
using System.Collections.Generic;
using PatternMatching.Algorithms;

namespace PatternMatching.MatchingEngine
{
    
    public class Engine
    {
        private string BayerMooreAlgorithm = "BayerMooreAlgorithm";
        private string KMPAlgorithm = "KMPAlgorithm";

        private Algorithm algorithm;
        public Engine(string algorithm)
        {
            setUpEngineWith(algorithm);
        }
        public List<int> indexes(string text, string pattern)
        {
            return algorithm.getIndexes(text, pattern);
        }
        private void setUpEngineWith(string givenAlgorithm)
        {
            if (givenAlgorithm == BayerMooreAlgorithm)
            {
                algorithm = new BayerMooreAlgorithm();
            }
            else if (givenAlgorithm == KMPAlgorithm)
            {
                algorithm = new KMPAlgorithm();
            }
            else {
                algorithm = new NaiveAlgorithm();
            }
        }

    }
}
