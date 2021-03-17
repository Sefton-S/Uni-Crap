using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CMP1903M
{
    //class TicketMachine models a simple ticket machine
    //It prints a ticket of a single price if there is enough money
    class TicketMachine
    {
        //fields and properties
        private int _ticketPrice;
        private int _balance;
        private int _total;

        public int ticketPrice
        {
            get { return _ticketPrice; }
            set
            {
                if (value > 0)
                {
                    _ticketPrice = value;
                }

                else
                {
                    Console.WriteLine("Fucking idiot lol");
                }
                    
                
                
            }
        }

        public int balance
        {
            get { return _balance; }
            private set { _balance = value; }
        }

        public int total
        {
            get { return _total; }
            private set { _total = value; }
        }

        //methods
        //insertMoney - receive an amount of money from the customer
        //parameter: int
        //return: void
        public void insertMoney(int amount)
        {
            
            if(amount > 0)
            {
                _balance += amount;
                Console.WriteLine("stuff");
            }
            else
            {
                Console.WriteLine("Amount must be greater than 0");
            }

        }

        //printTicket - simulate the output of a ticket
        //parameter: none
        //return: void
        public void printTicket()
        {
            if(_ticketPrice > _balance)
            {
                Console.WriteLine($"You do not have enough money to buy the ticket. \nTicket price: £{_ticketPrice}\nYour balance: £{_balance}");
            }

            else
            {
                _balance -= _ticketPrice;
                _total += _ticketPrice;
                Console.WriteLine("******************");
                Console.WriteLine(" SoCS Line Ticket");
                Console.WriteLine($"   Price = £{_ticketPrice}");
                Console.WriteLine("******************");
                status();
            }
        }

        //status - returns the current total of money in this machine
        //parameter: none
        //return: void
        public void status()
        {
             Console.WriteLine($"Balance: £{_balance}"); Console.WriteLine($"Total: £{_total}"); Console.WriteLine($"Ticket Price: £{_ticketPrice}");
        }


    }
}
