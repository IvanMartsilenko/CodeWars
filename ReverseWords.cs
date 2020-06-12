using System;
using System.Collections.Generic;
using System.Text;


namespace CodeWars
{
    public class ReverseWords
    {
        public static string SpinWords(string sentence)
        {
            string[] res = sentence.Split(' ');
            string result = "";
            foreach ( string word in res)
            {
                if (word.Length >= 5)
                {
                    char[] wordarray = word.ToCharArray();
                    Array.Reverse(wordarray);
                    string newWord = new string(wordarray);
                    result += newWord + " ";
                }
                else
                {
                    result +=  word + " ";
                }
            }
            result = result.TrimEnd(' ');
            return result;
        }

    
    }
}
