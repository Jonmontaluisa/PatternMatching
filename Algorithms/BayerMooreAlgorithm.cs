using System;
using System.Collections.Generic;

namespace PatternMatching.Algorithms
{
    class BayerMooreAlgorithm : Algorithm
    {
        static int NO_OF_CHARS = 256;
        public int max(int a, int b) { return (a > b) ? a : b; }

        public  override List<int> getIndexes(string text, string pattern)
        {
            List<int> indexes = new List<int>();

            int patternLength = pattern.Length;
            int textLength = text.Length;

            int[] badchar = badCharTable(pattern);

            int textIndex = 0; 

            while (textIndex <= (textLength - patternLength))
            {
                int patternIndex = patternLength - 1;

                while (patternIndex >= 0 && pattern[patternIndex] == text[textIndex + patternIndex])
                {
                    patternIndex--;
                }

                if (patternIndex < 0)
                {
                    indexes.Add(textIndex);
                    textIndex += (textIndex + patternLength < textLength) ? patternLength - badchar[text[textIndex + patternLength]] : 1;
                }
                else
                {
                    textIndex += max(1, patternIndex - badchar[text[textIndex + patternIndex]]);
                }             
            }
            return indexes;
        }

        public int[] badCharTable(string pattern)
        {

            int i;
            int[] badChar = new int[NO_OF_CHARS];

            for (i = 0; i < NO_OF_CHARS; i++)
                badChar[i] = -1;

            for (i = 0; i < pattern.Length; i++)
            {
                badChar[(int)pattern[i]] = i;
            }
            return badChar;
        }

    }
}
