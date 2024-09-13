using System;

namespace DataTypes{
    class Program{
        static void Prog(string[] args){
            Console.WriteLine("Enter the radius in m: ");
            string radios = Console.ReadLine();
            float Pi = 3.14f;
            double radius =  Convert.ToDouble(radios);
            double circumference =  radius * Pi * 2;
            Console.WriteLine("The circumference is " + circumference + "m \n");
            double area = radius * radius * Pi;
            Console.WriteLine("The area is " + area + "m^2");
        }

        static void Main(string[] args){
            Console.WriteLine("Enter your mark out of 60");
            double Mark = Convert.ToDouble(Console.ReadLine());
            double percentage = (Mark / 60) * 100;
            Console.WriteLine("Your percentage in the test is " + percentage + "% \n");
        }
    }
}
