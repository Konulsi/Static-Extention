using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InClass_Task.Models
{
    internal class Book
    {
        public string Name { get; set; }

        public static int Count { get; set; } = 0;

        public Book()
        {
            Count++;
        }

        public static void Test()
        {

        }
      

    }
}
