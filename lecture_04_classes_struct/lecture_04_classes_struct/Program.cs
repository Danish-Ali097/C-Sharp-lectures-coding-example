using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace lecture_04_classes_struct
{
    class Program
    {
        struct Books {
            public string name;
            public string authorName;
            public string category;
        };
        static void Main(string[] args)
        {
            #region structure
            Books books = new Books();
            books.name = "asdkjal";
            books.authorName = "jhhhhh";
            books.category = "fiction";
            Console.WriteLine(books.name);
            Console.ReadKey();
            #endregion

            #region Class
            // non perameterize constructor
            Car c1 = new Car();
            c1.Name = "Honda";
            c1.MakeYear = 1999;
            c1.Color = "black";
            c1.getAll();
            Console.ReadKey();

            // perameterize constructor
            Car c2 = new Car("Honda", 2020, "Silver");
            c2.getAll();
            Console.ReadKey();
            #endregion
        }
    }
}
