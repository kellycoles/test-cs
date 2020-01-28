using System;

namespace test
{
    class Program
    {
        static void Main(string[] args)
        {
            //Null Coalescing Operator
            //===================================================
            //if else way:
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

            //Null Coalescing Operator way:
            //int? ticketsOnSale = 100;
            //int availableTickets = ticketsOnSale ?? 0;
            //Console.WriteLine("Available tickets = {0}", availableTickets);

            // 4 Types of parameters
            //==============================================
            // value parameter
            int i = 0;
            MyMethod(i);
            Console.WriteLine(i);
        }
        public static void MyMethod(int j)
        {
            j = 101;
        }
    }
}
