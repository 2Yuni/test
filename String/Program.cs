using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHWExample
{
    class Program
    {
        static void Main(string[] args)
        {

            //StringBuilder
            string inputString = "aabcccccaaa";
            Console.WriteLine("StringBilder");
            Console.WriteLine(CountCharacthers(inputString));


            // string compare
            string s1 = "hello";
            string s2 = "world";
            CompareString(s1, s2);

            
        }
        

        //StringBuilder
        static string CountCharacthers(string inputString)
        {
            var returnString = new StringBuilder();

            int countLetters = 0;
            for (int i = 0; i < inputString.Length-1; i++)
            {
                countLetters++;
                if (inputString[i] != inputString[i + 1])
                {
                    returnString.Append(inputString[i] + "" + countLetters);
                    countLetters = 0;
                }
                if (i == inputString.Length - 2)
                {
                    countLetters++;
                    returnString.Append(inputString[i+1] + "" + countLetters);
                }
            }
            return returnString.Length < inputString.Length ? returnString.ToString() : inputString;
        }


        // string compare
        static void CompareString(string s1, string s2)
        {
            int result = string.Compare(s1, s2);
            if (result < 0)
            {
                Console.WriteLine("Строка s1 перед строкой s2");
            }
            else if (result > 0)
            {
                Console.WriteLine("Строка s1 стоит после строки s2");
            }
            else
            {
                Console.WriteLine("Строки s1 и s2 идентичны");
            }
        }
    }
}

