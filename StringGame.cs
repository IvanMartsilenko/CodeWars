using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class StringGame
    {
        public string workOnStrings(string a, string b)
        {

            a = new string (changeCase(changeArray(parceString(a)), a));
            b = new string (changeCase(changeArray(parceString(b)), b));
            return a + b;
        }
        public int[] parceString ( string a)
        {
            char[] _a = a.ToCharArray();
            int _index = 0;
            int[] _in = new int[_a.Length];
            foreach (char _elem in _a)
            {
                foreach (char _elem2 in _a)
                {
                    if (_elem == _elem2) _in[_index]++;
                }
                _index++;
            }
            return _in;
        }

        public int[] changeArray(int[] _in)
        {
            for (int i = 0; i < _in.Length; i++) _in[i] = _in[i] % 2;
            return _in;
        }

        public char [] changeCase(int[] _in, string a)
        {
            char[] _a = a.ToCharArray();
            for (int i = 0; i < _in.Length; i++)  if (Convert.ToBoolean(_in[i])) Char.ToUpper(_a[i]); 
            return _a;
        }
    }
}
