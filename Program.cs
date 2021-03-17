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
            TicketMachine t = new TicketMachine();
            bool loop = true;
            while(loop == true)
            {
            
            Console.WriteLine("What is the price of the ticket?");
            t.ticketPrice = Convert.ToInt32(Console.ReadLine());
            //Console.ReadLine();
            //int amount = 5;
            Console.WriteLine("How much money do you want to enter into the machine?");
            t.insertMoney(Convert.ToInt32(Console.ReadLine()));
            t.printTicket();
            }
            
        }
    }
}
