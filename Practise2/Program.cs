using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Practise2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Restaurant r = new Restaurant();
            while(true)
            {
                Console.WriteLine("1.Order");
                Console.WriteLine("2.Showbill");
                Console.WriteLine("3.Exit");
                int d = Convert.ToInt32(Console.ReadLine());
                if (d == 1)
                {
                    r.order();
                }
                else if (d == 2)
                {
                    r.showbill();
                }
                else
                    break;
            }
        }
    }
}
