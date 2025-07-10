using System;
using System.Globalization;

namespace Primeiro_proj {
    class Program {
        static void Main(string[] args)
        {
            int n1 = 3 + 4 * 2;
            int n2 = (4 + 3) * 2;
            int n3 = 17 % 3;
            double n4 = (double)10 / 8;
            double n5 = 10.0 / 3; // indica que é uma expresao double
            Console.WriteLine(n3);
            double a = 1.0, b = -3.0, c = -4.0;
            double delta = Math.Pow(b, 2.0) - 4.0 * a * c;
            double x1 = (-b + Math.Sqrt(delta)) / 2 * a;
            Console.WriteLine(delta);
            Console.WriteLine(x1);
           
            //float x = 4.5f;
            //double y = x;
            //double a;
            //float b;
            //b = (float)a;
            //double x = 10.35784;
            //int y = 32;
            //string z = "Maria";
            //char w = 'F';
            //Console.WriteLine("Bom dia!");
            //Console.WriteLine(x);
            //Console.WriteLine(x.ToString("F2"));
            //Console.WriteLine($"{z} tem {y} ano e de dinheiro {x:F2}");
            //Console.ReadLine();
        }
    }
}