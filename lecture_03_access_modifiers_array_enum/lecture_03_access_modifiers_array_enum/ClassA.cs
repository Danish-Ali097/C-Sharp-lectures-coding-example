using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_03_access_modifiers_array_enum
{
    class ClassA
    {
        public string str1 = "public string"; // accessable anywhere
        private string str2 = "private string"; // accessable only in the resedence class
        protected string str3 = "protected string"; // accessable to resedence class and all other classes who inherited this class

        public void display()
        {
            Console.WriteLine($"string in str1: {str1}\n");
            Console.WriteLine($"string in str2: {str2}\n");
            Console.WriteLine($"string in str3: {str3}");
        }
    }
}
