using System;
using System.Collections.Generic;
using System.Text;

namespace PatternMatching.Algorithms
{
    class NaiveAlgorithm : Algorithm
    {
        public override List<int> getIndexes(string text, string pattern)
        {
            List<int> indexes = new List<int>();
            for (int i = 0; i < text.Length; i++) {
                for (int j = 0; j < pattern.Length; j++)
                    if (text[i] == pattern[j])
                    {
                        i++;
                        j++;
                        if (j == pattern.Length)
                        {
                            indexes.Add(i - j);
                        }
                    }
                    else {
                        j = 0;
                        i = i - j + 1;
                    }
            }
            return indexes;
        }
    }
}
