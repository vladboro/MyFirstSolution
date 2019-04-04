using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public struct Point
    {
        public int X;
        public int Y;
    }

    public class Rectangle : Shape, IPrintable
    {
        private int w, h;

        public Rectangle() : base("Rectangle") { }

        public int Width
        {
            get { return w; }
            set { w = value; }
        }

        public int Height
        {
            get { return h; }
            set { h = value; }
        }

        public override int Area
        {
            get { return w * h; }
        }

        public override string GetName()
        {
            return "I'm rectangle";
        }

        public string Print()
        {
            return "Print: Rectangle";
        }

        public Point this[int vertexNumber] // 0..3
        {
            get
            {
                if (vertexNumber < 0 || vertexNumber > 3)
                    throw new IndexOutOfRangeException();
                Point p;
                p.X = 0;
                p.Y = 0;
                switch (vertexNumber)
                {
                    case 0:
                        p.X = this.X;
                        p.Y = this.Y;
                        break;
                    case 1:
                        p.X = this.X + w;
                        p.Y = this.Y;
                        break;
                    case 2:
                        p.X = this.X + w;
                        p.Y = this.Y + h;
                        break;
                    case 3:
                        p.X = this.X;
                        p.Y = this.Y + h;
                        break;
                }
                return p;
            }
        }

        public Point this[string vertexName]
        {
            get
            {
                Point p;
                p.X = 0;
                p.Y = 0;
                switch (vertexName)
                {
                    case "NW":
                        p.X = this.X;
                        p.Y = this.Y;
                        break;
                    case "NE":
                        p.X = this.X + w;
                        p.Y = this.Y;
                        break;
                    case "SE":
                        p.X = this.X + w;
                        p.Y = this.Y + h;
                        break;
                    case "SW":
                        p.X = this.X;
                        p.Y = this.Y + h;
                        break;
                    default:
                        throw new IndexOutOfRangeException();
                }
                return p;
            }
        }
    }
}
