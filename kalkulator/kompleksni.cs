using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace kalkulator
{
    class kompleksni
    {
        public double Re;
        public double Im;
        static public kompleksni zbir(kompleksni x, kompleksni y)
        {
            kompleksni z = new kompleksni();
            z.Re = x.Re + y.Re;
            z.Im = x.Im + y.Im;
            return z;
        }
        static public kompleksni razlika(kompleksni x, kompleksni y)
        {
            kompleksni z = new kompleksni();
            z.Re = x.Re - y.Re;
            z.Im = x.Im - y.Im;
            return z;
        }
        static public kompleksni proizvod(kompleksni x, kompleksni y)
        {
            kompleksni z = new kompleksni();
            z.Re = x.Re * y.Re - x.Im * y.Im;
            z.Im = x.Re * y.Im + x.Im * y.Re;
            return z;
        }
        static public kompleksni kolicnik(kompleksni x, kompleksni y)
        {
            kompleksni z = new kompleksni();
            double p = x.Re * y.Re + x.Im * y.Im;
            double q = x.Re * (-y.Im) + x.Re * y.Re;
            double r = x.Re * x.Re - y.Im * y.Im;
            z.Re = p / r;
            z.Im = q / r;
            return z;
        }
    }
}
