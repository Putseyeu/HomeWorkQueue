using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeWorkQueue
{
    class Program
    {
        static void Main(string[] args)
        {
            int allMoneyShop = 0;
            Queue<int> clients = new Queue<int>();
            FillClients(clients);

            while(clients.Count != 0)
            {
                allMoneyShop =+ clients.Dequeue();
                Console.WriteLine($"Баланс магазина состовляет {allMoneyShop}");
                Console.ReadLine();
                Console.Clear();
            }
            Console.WriteLine("клиентов больше нету.");
        }

        static void FillClients(Queue<int> clients)
        {
            Console.WriteLine("Укажите количесво клиентов записаных сегодня на приём очереди");
            int allClient = Convert.ToInt32(Console.ReadLine());
            Random random = new Random();
            int minPrice = 100;
            int maxPrice = 500;

            for (int i = 0; i < allClient; i++)
            {               
                clients.Enqueue(random.Next(minPrice,maxPrice));
            }
        }
    }
}
