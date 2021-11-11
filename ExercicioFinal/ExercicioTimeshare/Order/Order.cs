using System;
using System.Collections.Generic;

namespace ExercicioTimeshare
{
    public class Order : OrderAux
    {
        private int QtdAdd { get; set; }
        private int QtdRemove { get; set; }

        public Order(Customer customer)
        {
            Customer = customer;
        }
        public List<int> listaQtd = new List<int>();

        public void AddItem(Product p, int qtd = 0)
        {
            Console.WriteLine($"Produto {p.Name}");
            QtdAdd = qtd = QuantityItems();
            double totalCompra = qtd * p.Price;
            Total = Total + totalCompra;
            ProductDatabase.shared.Add(p);
            listaQtd.Add(qtd);
        }

        public void RemoveItem(Product p, int qtd = 0)
        {
            Console.WriteLine($"Produto {p.Name} removido.");
            QtdRemove = qtd = QuantityItems();
            while (QtdRemove > QtdAdd)
            {
                Console.WriteLine("A quantidade de itens removidos não pode ser maior que a adicionada.");
                QtdRemove = qtd = QuantityItems();
            }
            double totalCompra = qtd * p.Price;
            Total -= totalCompra;
            ProductDatabase.shared.Delete(p);
        }

        public void GetQtd()
        {
            foreach (var item in listaQtd)
            {
                Console.WriteLine(item);
            }
        }


        public void GetInfos()
        {
            Console.WriteLine("----------[ I N I C I O ]----------");
            Console.WriteLine("");
            Console.WriteLine("*[ R E S U M O  DO  P E D I D O ]*");
            Console.WriteLine("");
            FormatedData();
            ClientData();
            Status();
            GetProductNamePrice();
            GetTotal();
            Console.WriteLine("-------------[ F I M ]-------------");
        }


    }
}