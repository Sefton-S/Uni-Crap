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
                    Console.WriteLine("Do you have a discount code? (Enter \"y\" for yes, anything else for no)");
                    string discountYesNo = Console.ReadLine();
                    if(discountYesNo == "y")
                    {
                        discount();
                    }
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
                Console.WriteLine("Do you want a refund? (Enter \"y\" for yes, anything else for no)");
                string refundYesNo = Console.ReadLine();
                if(refundYesNo == "y")
                {
                    //refund();
                }
                else
                {
                    _balance += amount;
                }
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
        public void empty()
        {
            Console.WriteLine("Do you want to empty the machine? (Enter \"y\" for yes, anything else for no)");
            string answer = Console.ReadLine();
            if (answer == "y")
            {
                _total = 0;
                Console.WriteLine("Machine successfully emptied");
            }
        }
        public void discount()
        {
            Console.WriteLine("Enter your code");
            string code = Console.ReadLine();
            if (code == "123")
            {
                _ticketPrice -= 2;
                if (_ticketPrice < 0)
                {
                    _ticketPrice = 0;
                }
                Console.WriteLine("Discount successfully applied for £2 off your ticket");
                Console.WriteLine($"Your ticket now costs £{_ticketPrice}");
            } 
        }
        public void refund()
        {

        }
    }
}
