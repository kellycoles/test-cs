using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //int? ticketsOnSale = 100;
            //int availableTickets;
            //if (ticketsOnSale == null)
            //{
            //    availableTickets = 0;
            //}
            //else
            //{
            //    //cast null to int
            //    availableTickets = (int)ticketsOnSale;
            //}

            //Null Coalescing Operator
            int? ticketsOnSale = 100;
            int availableTickets = ticketsOnSale ?? 0;
            Console.WriteLine("Available tickets = {0}", availableTickets);
        }
    }
}
