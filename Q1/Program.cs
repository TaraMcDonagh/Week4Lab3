using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Q1
{
    class Program
    {
        /*Create a Car class with the following properties - Make, Model, 
         *Current Speed, Engine Size. Use long hand properties, with private 
         *attributes and getters and setters.  In the program.cs file make use of 
         *this class by creating two objects and displaying details on the cars. */
        static void Main(string[] args)
        {

            Car car1 = new Car();
            car1.Make = "Skoda";
            car1.Model = "Yeti";
            car1.Speed = 50;
            car1.Size = 1.5;
            Car car2 = new Car();
            car2.Make = "Audi";
            car2.Model = "A4";
            car2.Speed = 80;
            car2.Size = 1;
            Console.WriteLine(car1.ToString());
            Console.WriteLine(car1.Accelerate());
            Console.WriteLine(car1.DisplayInfo());

            Console.WriteLine(car2.ToString());
            Console.WriteLine(car2.Accelerate());
            Console.WriteLine(car2.DisplayInfo());


        }
    }
}
