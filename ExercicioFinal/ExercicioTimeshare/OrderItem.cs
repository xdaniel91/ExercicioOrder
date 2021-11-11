using System;
using System.Collections;


namespace ExercicioTimeshare
{
    public class OrderItem
    {
        ArrayList myAL = new ArrayList();

        public int Qtd { get; set; }
        public double TotalValue { get; set; }
        public double ValueItem { get; set; }


        public OrderItem(Customer customer) {
            Console.WriteLine("ordem criada");       
        }

        public void OrderItemAdd(Product pItem, double pPrice = 0, int pQtd = 0)
        {
            pPrice = pItem.Price;
            Console.Write($"digite a quantidade desejada de {pItem.Name} ");
            pQtd = int.Parse(Console.ReadLine());           
            Console.WriteLine(pPrice);
            
           double TotalCompra = pPrice * pQtd;
            Console.WriteLine(TotalCompra);
            myAL.Add(TotalCompra);
            Qtd = pQtd;

        }

        public double GetTotalValue() {
            return 0;
        }

        public void Resumo()
        {
          
            Arraylist();

        }
        public void Arraylist()
        {
            //foreach (double item in myAL)
            //{
                
            //    Console.WriteLine(item[1] + item[2]);
            //}

            for (int i = 0; i < myAL.Count; i++)
            {
                Console.WriteLine(i+ i);
            }
        }




    }
}
