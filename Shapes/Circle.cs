using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Circle : Shape, IDisposable
    {
        public static readonly double Pi = 3.1415926;

        private int radius; // test change

        public Circle(int radius) : base("Circle")
        {
            this.radius = radius;
        }

        public int Radius
        {
            [Author("Vasya", EMail = "vpupkin@mail.ru")]
            set { this.radius = value; }
            [Author("Petya", EMail = "petya@mail.ru")]
            get { return this.radius; }
        }


        public override string ToString()
        {
            return string.Format("Circle with radius {0}", this.radius);
        }

        public override int Area
        {
            get
            {
                return 3 * radius * radius;
            }
        }

        public void Dispose()
        {
            Console.WriteLine("Circle Dispose {0}", radius);
            GC.SuppressFinalize(this);
        }

        ~Circle()
        {
            Console.WriteLine("Circle Finalzer {0}", radius);
        }
    }
}
