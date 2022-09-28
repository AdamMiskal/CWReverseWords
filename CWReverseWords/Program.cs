using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CWReverseWords
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ReverseWords("gia ela edw re  mimou"));
            
        }
        public static string ReverseWords(string str)
        {
                //char[] arr = str.ToCharArray();
                //Array.Reverse(arr);
                //return new string(arr);

            //string strrev = "";
            //foreach (var word in str.Split(' '))
            //{
            //    string temp = "";
            //    foreach (var ch in word.ToCharArray())
            //    {
            //        temp = ch + temp;
            //    }
            //    strrev = strrev + temp + " ";
            //}

            //return strrev;
            var reversedWords = string.Join(" ",
            str.Split(' ')
           .Select(x => new String(x.Reverse().ToArray())));

            return reversedWords;
        }
    }
}
