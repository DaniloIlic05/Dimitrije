using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalkulator
{
    class rimski
    {
        //public string[] rim = new string[100];
        static private int Int_value(char simbol)
        {
            switch (simbol)
            {
                case 'I':
                    return 1;
                case 'V':
                    return 5;
                case 'X':
                    return 10;
                case 'L':
                    return 50;
                case 'C':
                    return 100;
                case 'D':
                    return 500;
                case 'M':
                    return 1000;
                default: return -1;
            }
        }
        static public int ConvertToInt(string rimski)
        {
            var sum = 0;
            for (var i = 0; i < rimski.Length; i++)
            {
                var tr = Int_value(rimski[i]);
                if (tr == -1)
                    return -1;

                if ((i + 1) < rimski.Length)
                {
                    var next = Int_value(rimski[i + 1]);
                    if (next == -1)
                        return -1;

                    if (next > tr)
                    {
                        if (next > 10 * tr)
                            return -1;

                        sum -= tr;
                        continue;
                    }
                }
                sum += tr;
            }
            return sum;
        }
        static public int zbir(int n, int m)
        {
            return m + n;
        }
        static public int razlika(int n, int m)
        {
            return n - m;
        }
        static public int proizvod(int n, int m)
        {
            return n * m;
        }
        static public int kolicnik(int n, int m)
        {
            return m - n;
        }
    }
}
