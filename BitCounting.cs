using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class BitCounting
    {
        public static int CountBits(int n)
        {
            int counter = 0;
            foreach ( char elem in (Convert.ToString(n, 2).Trim('0')).ToCharArray())
            {
                if (elem == '1') counter++;
            }
            return counter;
        }
    }
}
