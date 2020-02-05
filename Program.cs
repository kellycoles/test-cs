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
            //Console.WriteLine("i is: {0}", i);

            // reference parameter
            //===================
            //int i = 0;
            //MyMethod(ref i);
            //Console.WriteLine("i is: {0}", i);

            //out parameter
            //================
            //int total = 0;
            //int product = 0;
            //Calculate(10, 20, out total, out product);
            //Console.WriteLine("the total is {0} and the product is {1}", total,product);

            //params parameters
            //==================
            //int[] Numbers = new int[3];
            //Numbers[0] = 101;
            //Numbers[1] = 344;
            //Numbers[2] = 21;

            //ParamsMethod(Numbers);

            //this works, too
            //ParamsMethod(14, 2, 11);


            // reverse string line 99
            string result =ReverseStringDirect(" The dog went for a walk");
            Console.WriteLine(result);
        }

        // value parameter method
        //public static void MyMethod(int j)
        //{
        //    j = 101;
        //    Console.WriteLine("j is: {0}", j);
        //}

        // reference parameter method
        //public static void MyMethod(ref int j)
        //{
        //    j = 101;
        //Console.WriteLine("j is: {0}", j);
        //}

        //out parameter method
        //public static void Calculate(int num1, int num2,out int sum, out int product)
        //{
        //    sum = num1 + num2;
        //    product = num1 * num2;
        //}

        // params parameter method
        //params keyword makes passing parameters optional...can be only one number
        //public static void ParamsMethod(params int[] Numbers)
        //{
        //    Console.WriteLine("There are {0} elements", Numbers.Length);
        // foreach(int i in Numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        // reverse string
        public static string ReverseStringDirect(string s)
        {
            char[] array = new char[s.Length];
            int forward = 0;
            for (int i = s.Length - 1; i >= 0; i--)
            {
                array[forward++] = s[i];
            }
            return new string(array);
        }

    }
}
