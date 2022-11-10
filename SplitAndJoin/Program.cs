using System;
using System.Collections.Generic;
using System.Text;

namespace ClassesHWExample
{
    class Program
    {
        static void Main(string[] args)
        {

            string text = "И поэтому все так произошло";
            SplitWord(text);
            Console.WriteLine("\nJoin\n");
            string s1 = "Бывают";
            string s2 = "в";
            string s3 = "жизни";
            string s4 = "огорчения";
            string s5 = "(";
            string[] values = new string[] { s1, s2, s3, s4, s5 };

            string s6 = string.Join(" ", values);
            Console.WriteLine(s6); 
        }
        
        static void SplitWord(string text)
        {
            string[] words = text.Split(new char[] { ' ' });

            foreach (string s in words)
            {
                Console.WriteLine(s);
            }
        }
    }
}