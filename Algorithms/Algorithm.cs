using System;
using System.Collections.Generic;

namespace PatternMatching.Algorithms
{
    abstract class Algorithm
    {
        public abstract List<int> getIndexes(string txt, string pat);
    }
}
