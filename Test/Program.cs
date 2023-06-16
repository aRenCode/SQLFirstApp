// See https://aka.ms/new-console-template for more information
using System;
using Test;
namespace MyApp // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        public class Cat1
        {
            
            public Cat1(int x)
            {
                int y;
                y = x;
            }
            public string Name(string name) {
                return name;
            }

        }
        static void Main(string[] args)
        {
            //Cat a;
           // Cat1 a1 = new Cat1(1);
            Console.WriteLine("Hello World!");

            int[] years = { 2013, 2014, 2015 };
            int[] population = { 1025632, 1105967, 1148203 };
            //var sb = new System.Text.StringBuilder();
            //sb.Append(String.Format("{0,6} {1,15}\n\n", "Year", "Population"));
            Console.WriteLine(String.Format("{0,-6} {1,16}\n\n", "Year", "Population"));
            for (int index = 0; index < years.Length; index++)
                Console.WriteLine(String.Format("{0,6} {1,15}\n", years[index], population[index]));

            Console.WriteLine(String.Format("{0:00.0}", 123.4567));      // "123.5"
            Console.WriteLine(String.Format("{0:00.0}", 2));       // "23.5"
            String.Format("{0:00.0}", 3.4567);        // "03.5"
            String.Format("{0:00.0}", -3.4567);
        }
    }
}
