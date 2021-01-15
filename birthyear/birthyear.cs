using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ConsoleApplication1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("tamant chanda : ");
            DateTime aesta = DateTime.Now;
            int taman = Convert.ToInt32(Console.ReadLine());
            int birth = aesta.Year - taman;
            Console.WriteLine("to shali " + birth + " hatuytata dunyawa.");
            Console.ReadLine();
        }
    }
}
