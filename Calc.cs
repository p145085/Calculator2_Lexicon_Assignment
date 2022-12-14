using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Calculator2_Lexicon_Assignment
{
    public static class Calc
    {
        public static double Addition(double[] vals)
        {
            return vals.Sum();
        }
        public static double Subtraction(double[] vals)
        {
            double sum = vals[0];
            for (int i = 1; i < vals.Length; i++)
            {
                sum = sum - vals[i];
            }
            return sum;
        }
        public static double Multiplication(double[] vals)
        {
            double sum = vals[0];
            for (int i = 1; i < vals.Length; i++)
            {
                sum = sum * vals[i];
            }
            return sum;
        }
        public static double Division(double[] vals)
        {
            try
            {
                double sum = vals[0];
                for (int i = 1; i < vals.Length; i++)
                {
                    sum = sum / vals[i]; // Why does the last iteration equal 8 and not throw an exception?
                }
                return sum;
            } catch (DivideByZeroException ex)
            {
                throw new DivideByZeroException(ex.Message);
            }
        }
    }
}
