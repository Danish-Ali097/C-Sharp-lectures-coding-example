using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_04_classes_struct
{
    class Car
    {
        // Properties
        public string Name { get; set; }
        public int MakeYear { get; set; }
        public string Color { get; set; }

        // Default Constructor
        public Car()
        {

        }

        // Parameterize Constructor
        public Car(string Name, int MakeYear, string Color)
        {
            this.Name = Name;
            this.MakeYear = MakeYear;
            this.Color = Color;
        }

        public void getAll()
        {
            Console.WriteLine($"Name: {Name}, Year of making: {MakeYear}, Color: {Color}");
        }
    }
}
