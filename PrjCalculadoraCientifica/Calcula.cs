using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrjCalculadoraCientifica
{
    public class Calcula
    {
        public String mSeno(String v)
        {
            double sin = double.Parse(v);
            return Math.Sin((sin * Math.PI) / 180) + "";
        }

        public String mCosseno(String v)
        {
            double num = double.Parse(v);
            return Convert.ToInt32(Math.Cos(num)) + "";
        }

        public Double Calcular(Double v1, Double v2, String op)
        {
            Double total = 0.0;

            if (op.Equals("+"))
                total = v1 + v2;
            if (op.Equals("-"))
                total = v1 - v2;
            if (op.Equals("/"))
                total = v1 / v2;
            if (op.Equals("x"))
                total = v1 * v2;
            return total;
        }

        public String Binário(String v)
        {
            int num = int.Parse(v);
            string bina = Convert.ToString(num, 2);
            return bina;
        }

        public String Decimal(String v)
        {
            string num = v;
            int deci = Convert.ToInt32(num, 2);
            return deci.ToString() ;
        }
             
        public String Invertido(String v)
        {
            double inv = Double.Parse(v);
            v = (inv * -1) + "";
            return v;
        }


    }
}
