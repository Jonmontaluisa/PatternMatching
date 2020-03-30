using System;
using System.Collections.Generic;

namespace PatternMatching.Algorithms
{
    class KMPAlgorithm : Algorithm
    {
        
        int[] lps;

        

        public override List<int> getIndexes(string text, string pattern)
        {
            int patternLength = pattern.Length;
            int textLength = text.Length;
            List<int> indexes = new List<int>();
            lps = computeLPSArray(pattern);

            int textIndex = 0;
            int patternIndex = 0;
            while (textIndex < textLength)
            {
                if (pattern[patternIndex] == text[textIndex])
                {
                    patternIndex++;
                    textIndex++;
                }
                if (patternIndex == patternLength)
                {
                    indexes.Add(textIndex - patternIndex);
                    patternIndex = lps[patternIndex - 1];
                }

                else if (textIndex < textLength && pattern[patternIndex] != text[textIndex])
                {
                    
                    if (patternIndex != 0)
                        patternIndex = lps[patternIndex - 1];
                    else
                        textIndex = textIndex + 1;
                }
            }
            return indexes;
        }

        private int[] computeLPSArray(string pattern)
        {
            int[] lps = new int[pattern.Length];
            int lenOfSubpatern = 0;
            int i = 1;
            lps[0] = 0; 

            while (i < pattern.Length)
            {
                if (pattern[i] == pattern[lenOfSubpatern])
                {
                    lenOfSubpatern++;
                    lps[i] = lenOfSubpatern;
                    i++;
                }
                else
                 {

                    if (lenOfSubpatern != 0)
                    {
                        lenOfSubpatern = lps[lenOfSubpatern - 1]; 
                    }
                    else 
                    {           
                        lps[i] = lenOfSubpatern;
                        i++;
                    }
                }
            }
            return lps;
        }
    }
}
