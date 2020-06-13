using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars
{
    public class JosephusSurvivor
    {
        public static int JosSurvivor(int n, int k)
        {
            Queue<int>  _children = new Queue<int>(Enumerable.Range(1, n));
            while(_children.Count != 1)
            {
                for( int i = 1; i < k; i++) { _children.Enqueue(_children.Dequeue()); }
                _children.Dequeue();
            }
            return _children.Peek();
        }
    }
}
