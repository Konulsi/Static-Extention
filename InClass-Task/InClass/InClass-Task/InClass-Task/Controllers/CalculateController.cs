using ServiceLayer.Services;
using ServiceLayer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Task.Controllers
{
    internal class CalculateController
    {
        public void Calculate()
        {
            ICalculationService service = new CalculationService();
           
            var result = service.Calculate(5, 7, "*");
           
            Console.WriteLine(result);
        }
    }
}
