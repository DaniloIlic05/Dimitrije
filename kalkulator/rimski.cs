using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;

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
            var zbir = 0;
            for (var i = 0; i < rimski.Length; i++)
            {
                var tr = Int_value(rimski[i]);
                if (tr == -1)
                    return -1;

                if ((i + 1) < rimski.Length)
                {
                    var sl = Int_value(rimski[i + 1]);
                    if (sl == -1)
                        return -1;

                    if (sl > tr)
                    {
                        if (sl > 10 * tr)
                            return -1;

                        zbir -= tr;
                        continue;
                    }
                }
                zbir += tr;
            }
            return zbir;
        }
        static public string ConvertToString(int n)
        {
            string[] jedinice = { "", "I", "II", "III", "IV", "V", "VI", "VII", "VIII", "IX" };
            string[] desetice = { "", "X", "XX", "XXX", "XL", "L", "LX", "LXX", "LXXX", "XC" };
            string[] stotine = { "", "C", "CC", "CCC", "CD", "D", "DC", "DCC", "DCCC", "DM" };
            string[] hiljade = { "", "M", "MM", "MMM" };
            if (!(n >= 1 && n <= 3999))
            {
                return "";
            }
            int m = n / 1000;
            int ostatak = n % 1000;
            int c = ostatak / 100;
            ostatak = ostatak % 100;
            int d = ostatak / 10;
            ostatak = ostatak % 10;
            int u = ostatak;
            return hiljade.ElementAtOrDefault(m) + stotine.ElementAtOrDefault(c) + desetice.ElementAtOrDefault(d) + jedinice.ElementAtOrDefault(u);
        }
        static public bool ProveriRimski(string str)
        {
            string strRegex = @"^M{0,3}(CM|CD|D?C{0,3})(XC|XL|L?X{0,3})(IX|IV|V?I{0,3})$";
            if (Regex.IsMatch(str, strRegex))
                return (true);
            else
                return (false);
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