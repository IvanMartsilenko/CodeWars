using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    class ReverseWords
    {
        private static string SpinWords(string sentence)
        {
            string[] res = sentence.Split(' ');
            string result = "";
            foreach ( string word in res)
            {
                if(word.Length == 5)
                {
                    char[] wordarray = word.ToCharArray();
                        Array.Reverse(wordarray);
                        string newWord = new string(wordarray);
                    result+= newWord;
                }
                result += word;
            }
            return result;
        }


    }
}
