using System;
using Shapes;
using System.Reflection;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            var lastArg = args.Reverse();
            Circle c1 = new Circle(20);
            Rectangle r1 = new Rectangle();
            r1.X = 100;
            r1.Y = 200;
            r1.Width = 20;
            r1.Height = 30;
            for (int i = 0; i < 4; i++)
            {
                Shapes.Point pp = r1[i];
                Console.WriteLine("X = {0}, Y = {1}", pp.X, pp.Y);
            }
            Shapes.Point p = r1["NE"];
            Console.WriteLine("X = {0}, Y = {1}", p.X, p.Y);

            Type t = c1.GetType();
            MethodInfo mi = t.GetMethod("get_Radius");
            foreach (AuthorAttribute author in  mi.GetCustomAttributes(typeof(AuthorAttribute)))
            {
                Console.WriteLine("Author = {0}, EMail = {1}", author.AuthorName, author.EMail);
            }

            using (Circle c2 = new Circle(30))
            {
                c1.PrintCoordinates();
                r1.PrintCoordinates();
                Console.WriteLine(c1.Area);
                Console.WriteLine(c2.Area);
            }

        }
    }

    public static class MyExtensions
    {
        public static void PrintCoordinates(this Shape s)
        {
            Console.WriteLine("Shape Coordinates: {0}, {1}", s.X, s.Y);
        }
    }
}
