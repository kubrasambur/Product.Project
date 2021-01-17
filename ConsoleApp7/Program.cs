using System;

namespace ConsoleApp7
{
    class Program
    {
        static void Main(string[] args)
        {
            Product prdct1 = new Product();
            prdct1.prdctName = "Sneaker";
            prdct1.sneackerNo = 39;
            prdct1.gender = "Unisex";
            prdct1.price = 90;
            prdct1.discountDeadline = 10;

            Product prdct2 = new Product();
            prdct2.prdctName = "Jean";
            prdct2.size = 38;
            prdct2.gender = "Woman";
            prdct2.price = 30;
            prdct2.discountDeadline = 3;

            Product prdct3 = new Product();
            prdct3.prdctName = "Tie";
            prdct3.gender = "Man";
            prdct3.price = 5;
            prdct3.discountDeadline = 15;

            Product[] Prdcts = {prdct1,prdct2,prdct3 };

            for(int i=0; i < Prdcts.Length; i++)
            {
                Console.WriteLine("Product Name : " + Prdcts[i].prdctName);
            }
            Console.WriteLine("                  ");
            Console.WriteLine("For loop finished");
            Console.WriteLine("                  ");

            foreach (var prdct in Prdcts)
            {
              
                Console.WriteLine("Product Gender : " + prdct.gender + "\nProduct Price : $" + prdct.price);
                
            }
            Console.WriteLine("                  ");
            Console.WriteLine("Foreach loop finished");
            Console.WriteLine("                  ");
            int a = 0;
            while (a < Prdcts.Length)
            {
                Console.WriteLine("Product's Discount finish in " + Prdcts[a].discountDeadline + " days" );
                a++;
            }
            Console.WriteLine("                  ");
            Console.WriteLine("While loop finished");
        }
    
    }
    class Product
    {
        public int price, discountDeadline, sneackerNo, size;
        public string gender, prdctName;
       
    }
}
