using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Static_Extention.Helper
{
    public static class Extention
    {
        public static int Num { get; set; } = 1;
        public static int GetFactorial(this int num)
        {
            int multiple = 1;
            
            for (int i = 1; i <= num; i++)
            {
                multiple *= i;
            }
            return multiple;    
        }

      

        public static double GetNumPower(this int number , int power)
        {
            var result= Math.Pow(number, power );

            return result;
        }


    }
}
