using System;
using System.Collections.Generic;
using System.Text;


namespace CodeWars
{
    public class PerfectPower
    {
        public static ( int , int)? IsPerfectPower1(int n)
        {
            for (int i = 2; i < n; i++)
            {
                // Math.Log(125, 5) = 		System.Math.Log returned	3.0000000000000004	double, so i will refactor  
                if (Math.Abs(Math.Log(n, i) - Math.Truncate(Math.Log(n, i))) < 0.00001 || (Math.Abs(Math.Log(n, i) - (Math.Truncate(Math.Log(n, i))+ 1))) < 0.00001) return (i, Convert.ToInt32(Math.Truncate(Math.Log(n, i))));
            }
            return null;
        }
        public static (int, int)? IsPerfectPower(int n)
        {
            for (int i = 2; i < n; i++)
                for (int j = 2; j < n; j++) if (Math.Pow(i, j) == n) return (i, j);
            return null;
        }

    }
}
