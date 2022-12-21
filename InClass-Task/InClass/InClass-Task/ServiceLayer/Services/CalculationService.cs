using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServiceLayer.Services
{
    public class CalculationService : ICalculationService
    {
        public double Calculate(double n, double m, string operation)
        {
            double result;

            switch (operation)
            {
                case "+":
                    result= n+m;
                    return result;
                case "-": 
                    result= n-m;    
                    return result;  
                case "*":   
                    result= n*m;    
                    return result;
                case "/":               
                    result= n/m;
                    return result;                    
            }

            return default;
        }
    }
}
