using System;

namespace CodeWars
{
    public class StringGame
    {
        public string workOnStrings(string a, string b)
        {

            string _a = new string (changeCase(changeArray(parceString(b)), b, a));
            string _b = new string (changeCase(changeArray(parceString(a)),a, b));
            return _a + _b;
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

        public char [] changeCase( int[] _in, string a, string b)
        {
            char[] _a = a.ToCharArray();
            char[] _b = b.ToCharArray();
            for (int i = 0; i < _a.Length; i++)
                for (int j = 0; j < _b.Length; j++)
                    if (Char.ToLower(_a[i]) == Char.ToLower(_b[j]) && Convert.ToBoolean(_in[i])) { if (_b[j] >= 'a') _b[j] = Char.ToUpper(_b[j]);
                        else _b[j] = Char.ToLower(_b[j]); } 
            return _b;
        }
    }
}
