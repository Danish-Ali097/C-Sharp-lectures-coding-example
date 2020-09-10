using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_02_conditional_statemensts_and_loops
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 10;

            // If Condition
           /* if (a > 10)
            {
                Console.WriteLine("value of a is greater then 10");
            }
            Console.WriteLine($"value of a = {a}");
            Console.ReadKey();*/

            // If Else Condition
             /*if (a > 10)
             {
                 Console.WriteLine("value of a is greater then 10");
             }
             else
             {
                 Console.WriteLine("value of a is less then or equal to 10");
             }
            Console.ReadKey();*/

            // Switch statement
             /*switch (a)
             {
                 case 10:
                     Console.WriteLine("value is 10");
                     break;
                 case 20:
                     Console.WriteLine("value is 20");
                     break;
                 default:
                     Console.WriteLine("value is not 10 or 20");
                     break;
             }
            Console.ReadKey();*/

            /////////////////////////////////////////////////////
            ///////////////        LOOPS      //////////////////
            ////////////////////////////////////////////////////
            
            // While loop
           /* while(a < 20)
            {
                a = a + 1;
                Console.WriteLine($"Value of a = {a}");
            }
            Console.ReadKey();*/

           /* // do While loop
            do {
                Console.Write("This loop executes atleast one time");
            } while (a == 10);

            // for loop
            for (int i = 0; i < 5; i++)
            {
                Console.WriteLine(i);
            }

            // foreach loop
            ArrayList list = new ArrayList();
            list.Add("John Doe");
            list.Add("Jane Doe");
            list.Add("Someone Else");

            foreach (string name in list)
            {
                Console.WriteLine(name);
            }*/

        }
    }
}
