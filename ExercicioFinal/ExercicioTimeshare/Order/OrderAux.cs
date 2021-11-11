using System;
using System.Text.RegularExpressions;

namespace ExercicioTimeshare
{
    public class OrderAux
    {
        public Customer Customer { get; set; }

        public double Total { get; set; }
        
        string orderStatus = "nao";

        public void FinalizeOrder()
        {
            string resp = "";
            Console.WriteLine("Deseja finalizar o pedido?");
            Console.WriteLine("Digite sim ou nao:");
            resp = Console.ReadLine().ToLower();

            while (resp != "sim" && resp != "nao")
            {
                 Console.WriteLine("Resposta inválida.");
                 Console.WriteLine("Digite sim ou nao:");
                 resp = Console.ReadLine().ToLower();
            } 
            orderStatus = resp;
        }

        public void Status()
        {
            string status;
            if (orderStatus == "sim")
            {
                status = "| Status: Finalizado";
            }
            else
            {
                status = "| Status: Pendente";
            }
            Console.WriteLine(status);
        }

        
        public void FormatedData()
        {
            string dataHora = DateTime.Now.ToString();
            string padraoData = "[0-9]{2}/[0-9]{2}/[0-9]{4}";
            string padraoHora = "[0-9]{2}:[0-9]{2}";
            Console.WriteLine($"| Data: {Regex.Match(dataHora, padraoData)}");
            Console.WriteLine($"| Hora: {Regex.Match(dataHora, padraoHora)}");
        }

        public double GetTotal()
        {
            Console.WriteLine($"| Total da compra: {Total}");
            return Total;
        }

        //Return product position, Name, Price
        public void GetProductNamePrice()
        {
            Console.WriteLine("-----------------------------------");
            int position = 1;
            foreach (var product in ProductDatabase.shared.GetAll())
            {
                Console.WriteLine($"| Produto {position}");
                Console.WriteLine($"|   Nome: {product.Name}");
                Console.WriteLine($"|   Valor unitário: {product.Price}");
                position++;
                Console.WriteLine("-----------------------------------");
            }
        }
        
        public void ClientData()
        {
            Console.WriteLine($"| Cliente: {Customer.Name}");
        }

        public int QuantityItems()
        {
            try
            {
                int qtdItens = 0;
                Console.Write("Digite a quantidade: ");
                qtdItens = int.Parse(Console.ReadLine());
                while (qtdItens <= 0)
                {
                    Console.WriteLine("Quantidade não pode ser menor que 0.");
                    Console.WriteLine("Digite a quantidade: ");
                    qtdItens = int.Parse(Console.ReadLine());
                }
                return qtdItens;
            }
            catch (Exception)
            {

                Console.WriteLine("Apenas numeros inteiros.");
                
            }
            return 0;
        }

        public int ChosenOption()
        {
            var result = -1;
            do
            {
                Console.WriteLine("Escolha uma opção");
                result = Int32.Parse(Console.ReadLine());
            } while (result == 1);
            return result;
        }


    }
}
