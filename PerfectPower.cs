using System;
using System.Collections.Generic;
using System.Text;


namespace CodeWars
{
    public class PerfectPower
    {
        public static ( int , int)? IsPerfectPower(int n)
        {
            for (int i = 2; i < n; i++)
            {
                // Math.Log(125, 5) = 		System.Math.Log returned	3.0000000000000004	double, so i will refactor  
                if (Math.Abs(Math.Log(n, i) - Math.Truncate(Math.Log(n, i))) < 0.00001 || (Math.Abs(Math.Log(n, i) - (Math.Truncate(Math.Log(n, i))+ 1))) < 0.00001) return (i, Convert.ToInt32(Math.Truncate(Math.Log(n, i))));
            }
            return null;
        }

    }
}
