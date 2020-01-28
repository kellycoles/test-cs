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
            //int i = 0;
            //MyMethod(i);
            //Console.WriteLine(i);

            // reference parameter
            //int i = 0;
            //MyMethod(ref i);
            //Console.WriteLine(i);

            //out parameters
            int total = 0;
            int product = 0;
            Calculate(10, 20, out total, out product);
            Console.WriteLine("the total is {0} and the product is{1}", total,product);
        }
        // value parameter method
        //public static void MyMethod(int j)
        //{
        //    j = 101;
        //}

        //// reference parameter method
        //public static void MyMethod(ref int j)
        //{
        //    j = 101;
        //}

        //out parameter method
        public static void Calculate(int num1, int num2,out int sum, out int product)
        {
            sum = num1 + num2;
            product = num1 * num2;
        }

    }
}
