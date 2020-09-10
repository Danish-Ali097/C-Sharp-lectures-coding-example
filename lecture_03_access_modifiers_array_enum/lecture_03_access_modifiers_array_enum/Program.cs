using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_03_access_modifiers_array_enum
{
    class Program : ClassA
    {
        // enum declaration
        private enum Days { mon, tue, wed, thur, fri, sat, sun};

        static void Main(string[] args)
        {
            // Arrays
            int[] arr = new int[5]; // declare an array of 5 indexes with no values
            Console.Write($"size of arr: {arr.Length}");

            int[] arr1 = new int[5]{ 5, 1, 2, 3, 4}; // declare an array of 5 indexes with no values
            Console.Write($"size of arr1: {arr1.Length}");

            int[] arr2 = { 1,2,3 }; // declring a array and its values determine the size of the array
            Console.Write($"size of arr2: {arr2.Length}");
            Console.ReadKey();


            /*

            // Jagged Array
            int[][] arr3 = new int[2][];

            arr3[0] = new int[3] { 1, 2, 3 };
            arr3[1] = new int[1] { 1 };
            Console.ReadKey();

            */

            /*
            // Enum usage
            Console.Write($"Value of mon: {Days.mon}");
            Console.ReadKey();
            */

            /*
            // Access Modifiers
            ClassA a = new ClassA(); // Public properties are accessable to any class
            Console.Write(a.str1);

            a.display(); // private properties are not accessable to any other class except the one in which it is declared

            Program p = new Program(); //protected properties of class is accessable to its declared class and the class that inherit it
            Console.Write(p.str3);
            Console.ReadKey();
            */
        }
    }
}
