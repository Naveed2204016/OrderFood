using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Practise2
{
    class Restaurant
    {
        public string[,] chicken;
        public string[,] pizza;
        public string[,] drinks;
        int cost = 0;
        public Restaurant()
        {
            chicken = new string[3,2] { { "Fried Chicken", "250" }, { "Chicken chill meal", "300" }, { "Chicken Steak Meal", "400" } };
            pizza = new string[3,2] { { "Bolognese Classic", "702" }, { "BBQ Chicken Pizza", "800" }, { "Pepperoni De Panago", "765" } };
            drinks = new string[2,2] { { "Lemonade", "60" }, { "Orange Juice", "30" } };
        }

        void addtocart(string[,] c,params int[] arr)
        {
            for(int i=0;i<arr.Length;i++)
            {
                cost += Convert.ToInt32(c[arr[i] - 1, 1]);
            }
        }
        public void showchicken()
        {
            Console.WriteLine();
            Console.WriteLine("        Item name      Tk");
            for (int i = 0; i <3; i++)
            { 
                Console.WriteLine(i + 1 + "." + chicken[i,0] + "  " + chicken[i, 1]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("How many items do you want to order?");
            int d;
            d = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[d];
            for(int i=0;i<arr.Length;i++)
            {
                int s;
                s=Convert.ToInt32(Console.ReadLine());
                arr[i] = s;
            }
            addtocart(chicken,arr);
        }

        public void showpizza()
        {
            Console.WriteLine("        Item name      Tk");
            for (int i = 0; i < 3; i++)
            {
                Console.WriteLine(i + 1 + "." + pizza[i, 0] + "  " + pizza[i, 1]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("How many items do you want to order?");
            int d;
            d = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[d];
            for (int i = 0; i < arr.Length; i++)
            {
                int s;
                s= Convert.ToInt32(Console.ReadLine());
                arr[i] = s;
            }
            addtocart(pizza, arr);
        }

        public void showdrinks()
        {
            Console.WriteLine("         Item name      Tk");
            for (int i = 0; i < 2; i++)
            {
                Console.WriteLine(i + 1 + "." + drinks[i, 0] + "  " +drinks[i, 1]);
            }
            Console.WriteLine(" ");
            Console.WriteLine("How many items do you want to order?");
            int d;
            d = Convert.ToInt32(Console.ReadLine());
            int[] arr = new int[d];
            for (int i = 0; i < arr.Length; i++)
            {
                int s;
                s = Convert.ToInt32(Console.ReadLine());
                arr[i] = s;
            }
            addtocart(drinks, arr);
        }
        public void order()
        {
            Console.WriteLine("Please select an item:1.Chicken,2.Pizza,3.Drinks");
            int d;
            d = Convert.ToInt32(Console.ReadLine());
            if (d == 1)
            {
            showchicken();
            }
            else if (d == 2)
            {
            showpizza();
            }
            else
            {
            showdrinks();
            }
        }

        public void showbill()
        {
            Console.WriteLine("Sir please pay " + cost + "Tk");
        }
         
            
    }
}
