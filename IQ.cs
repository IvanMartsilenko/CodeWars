using System;
using System.Collections.Generic;
using System.Text;

namespace CodeWars
{
    public class IQ
    {
        public static int Test(string numbers)
        {
            int EvenCounter = 0;
            int UnCounter = 0;
            int EvenIndex = 1;
            int UnIndex = 1;
            int res = 0;
            foreach (string _elem in numbers.Split(' '))
            {
                if (Convert.ToInt32(_elem) % 2 == 0) { EvenCounter++; EvenIndex = EvenCounter + UnCounter; }
                else { UnCounter++; UnIndex = EvenCounter + UnCounter; }
                if (EvenCounter == 1 && UnCounter > EvenCounter) { res = EvenIndex; break; }
                else if (UnCounter == 1 && UnCounter < EvenCounter) { res = UnIndex; break; }
            }
            return res;
            }
        }
    }
