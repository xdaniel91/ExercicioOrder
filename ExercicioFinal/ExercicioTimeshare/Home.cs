using System;
using System.Collections.Generic;
using System.Linq;

namespace ExercicioTimeshare
{
    public class Home
    {
        static void Main(string[] args)
        {
            //Inicialização de customer
            //Customer marcos = new Customer(cpf: "123456789", name: "Marcos", email: "marcos@gmail.com", birth: "12/12/2021");

            ////Inicialização de products
            //Product p1 = new Product("Notebook", 100.60);
            //Product p2 = new Product("Caneta", 400.89);
            //Product p3 = new Product("Monitor", 20.22);
            //Product p4 = new Product("Mouse", 50.40);
            //Product p5 = new Product("Sapato", 66.70);

            //Order marcosOrder = new Order(marcos);


            ////inicialização da lista de produtos.
            //var avaliableProducts = new List<Product>();
            //avaliableProducts.AddRange(new Product[] { p1, p2, p3, p4 });

            //// produtos ordenados por preço.
            //IOrderedEnumerable<Product> produtosOrdenados = avaliableProducts.OrderBy(pdts => pdts.Price);

            //Console.WriteLine("Olá. Seja bem-vindo! \nProdutos disponíveis: \n");
            //foreach (var pdts in produtosOrdenados)
            //{
            //    Console.WriteLine($"Produto: {pdts.Name}, price: {pdts.Price:c}");
            //}

            //var chosenOption = -1;

            //while (chosenOption != 0)
            //{
            //    chosenOption = Utils.ChoseOption();
            //    switch (chosenOption)
            //    {
            //        case 1:
            //            marcosOrder.AddItem(p1);
            //            break;
            //        case 2:
            //            marcosOrder.AddItem(p2);
            //            break;
            //        case 3:
            //            marcosOrder.AddItem(p3);
            //            break;
            //        case 4:
            //            marcosOrder.AddItem(p4);
            //            break;
            //        case 5:
            //            marcosOrder.AddItem(p5);
            //            break;

            //        default:
            //            Console.WriteLine("opção invalida");
            //            break;
            //    }
            //}

            Utils.RegisterProduct();
            Utils.GetStock();
            Utils.RegisterProduct();
            Utils.GetStock();
            Utils.RegisterProduct();
            Utils.GetStock();
            Utils.RegisterProduct();
            Utils.GetStock();
            Utils.RegisterProduct();
            Utils.GetStock();



            Console.ReadLine();
        }
    }
}
