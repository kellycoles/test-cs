using System;
using System.Collections.Generic;
using System.Linq;

namespace test {

    class Program {
        static void Main (string[] args) {
            
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
            //============================================================================

            // Find min num in an array
            int[] myRandom = new int[3];
            myRandom[0] = 4;
            myRandom[1] = 18;
            myRandom[2] = 6;
            var min = myRandom.Min ();
            Console.WriteLine ($" min is: {min}");

            // 4 Types of parameters
            //==============================================\

            // 1 value parameter
            int i = 0;
            MyMethod (i);
            Console.WriteLine ($"value i is: {0}");

            // 2 reference parameter
            //===================
            int j = 0;
            MyMethod (ref j);
            Console.WriteLine ($"ref j is: {0}", j);

            // 3 out parameter
            //================
            //int total = 0;
            //int product = 0;
            //Calculate(10, 20, out total, out product);
            //Console.WriteLine("the total is {0} and the product is {1}", total,product);

            // 4 params parameters
            //==================
            //int[] Numbers = new int[3];
            //Numbers[0] = 101;
            //Numbers[1] = 344;
            //Numbers[2] = 21;

            //ParamsMethod(Numbers);

            //this works, too
            //ParamsMethod(14, 2, 11);

            // 5 reverse string line 
            //string result =ReverseStringDirect("joe blow");
            //Console.WriteLine(result);

            // 6 Factorial
            //double factorial = Factorial(5);
            //Console.WriteLine(factorial);

            //reverse method
            List<string> name = new List<string> { "K", "e", "l", "l", "y" };
            foreach (string n in name)
            {
                Console.Write(n);
            }
            Console.Write(" ");
            name.Reverse();
            foreach (string n in name)
            {
                Console.Write(n);
              
            }
            Console.WriteLine();
            // 7  How to find the sum of digits of a positive integer?
            SumOfDigits(56);
        }

        //==================================================================================================
        // End Main
        //===================================================================================================

        // 1 value parameter method
        public static void MyMethod (int j) {
            j = 101;
            Console.WriteLine ("j is: {0}", j);
        }

        // 2 reference parameter method
        public static void MyMethod (ref int j) {
            j = 101;
            Console.WriteLine ("j is: {0}", j);
        }

        // 3 out parameter method
        //public static void Calculate(int num1, int num2,out int sum, out int product)
        //{
        //    sum = num1 + num2;
        //    product = num1 * num2;
        //}

        // 4  params parameter method
        //params keyword makes passing parameters optional...can be only one number
        //public static void ParamsMethod(params int[] Numbers)
        //{
        //    Console.WriteLine("There are {0} elements", Numbers.Length);
        // foreach(int i in Numbers)
        //    {
        //        Console.WriteLine(i);
        //    }
        //}

        // 5 reverse string
        public static string ReverseStringDirect (string s) {
            char[] array = new char[s.Length];
            int forward = 0;
            for (int i = s.Length - 1; i >= 0; i--) {
                array[forward++] = s[i];
            }
            return new string (array);
        }

        // 6 recursive function: factorial
        public static double Factorial (int num) {
            if (num == 0) {
                return 1;
            }
            return num * Factorial (num - 1);
        }

        // 7  How to find the sum of digits of a positive integer?
        internal static void SumOfDigits(int num)
        {
            int sum = 0;
            while (num > 0)
            {
                sum += num % 10;
                num /= 10;
            }
            Console.WriteLine(sum);
        }
    }
}