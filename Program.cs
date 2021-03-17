using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M
{
    class Program
    {
        static void Main(string[] args)
        {
            bool loop = true;
            while(loop == true)
            {
            TicketMachine t = new TicketMachine();
            Console.WriteLine("What is the price of the ticket?");
            t.ticketPrice = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();
            //int amount = 5;
            Console.WriteLine("How much money do you want to enter into the machine?");
            t.insertMoney(Convert.ToInt32(Console.ReadLine()));
            t.printTicket();
                Console.WriteLine("testing git push shit")
            }
            
        }
    }
}
