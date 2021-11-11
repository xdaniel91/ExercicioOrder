using System;
using System.Collections.Generic;

namespace ExercicioTimeshare
{
    public static class Utils
    {
        public static List<Product> Stock { get; set; }

        public static int ChoseOption()
        {
            var result = -1;
            do
            {
                try
                {
                    Menu();

                    result = Convert.ToInt32(Console.ReadLine());
                }
                catch (Exception)
                {
                    Console.WriteLine("Digite um número válido.");
                }
            }
            while (result == -1);

            return result;
        }



        public static void Menu()
        {
            Console.WriteLine();
            Console.WriteLine("Digite o número da opção desejada:");
            Console.WriteLine("1 - p1");
            Console.WriteLine("2 - p2");
            Console.WriteLine("3 - p3");
            Console.WriteLine("4 - p4");
            Console.WriteLine("5 - p5");
            Console.WriteLine("Digite 0 para sair.");

            Console.WriteLine();
        }


        public static void RegisterProduct()
        {
            var avaliableProducts = new List<Product>();
            //var registerOther = -1;



            Console.WriteLine("Digite o nome do produto");
            string nameProduct = Console.ReadLine();

            Console.WriteLine("Digite o preço do produto");
            double priceProduct = Double.Parse(Console.ReadLine());

            Product product = new Product(nameProduct, priceProduct);
            avaliableProducts.Add(product);
            Stock = avaliableProducts;
            //Console.WriteLine("deseja registrar outro produto? 1- Sim / 2- Não");
            //registerOther = Int32.Parse(Console.ReadLine());




        }

        public static List<Product> GetStock()
        {
            foreach (var item in Stock)
            {
                Console.WriteLine(item.Name);
            }
            return Stock;
        }
    }
}
