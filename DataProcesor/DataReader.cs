using System;
using System.Collections.Generic;
using System.IO;

namespace PatternMatching.DataProcesor
{
    class DataReader
    {
        private bool readFromTxtFile;
        public  DataReader(bool readFromText)
        {
            readFromTxtFile = readFromText;
        }

        public List<string> readTextAndPattern(string[] args)
        {
            if (readFromTxtFile)
            {
                return readFromTxt(args[0], args[1]);
            } else {
                return readFromConsole();
            }
        }

        public List<string> readFromTxt(string textFile, string patternFile)
        {
            List<string> data= new List<string>();
            string text = File.ReadAllText(textFile);
            data.Add(text);
            string pattern = File.ReadAllText(patternFile);
            data.Add(pattern);
            return data;
        }

        public List<string> readFromConsole()
        {
            List<string> data = new List<string>();
            Console.Write("Provide a text: ");
            string text = Console.ReadLine();
            data.Add(text);
            Console.Write("Provide a pattern(substring): ");
            string pattern = Console.ReadLine();
            data.Add(pattern);
            return data;
        }
    }
}
