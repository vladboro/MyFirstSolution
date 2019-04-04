using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public class Triangle : Shape
    {
        private int t1, t2, t3;

        public Triangle() : base("Triangle") { }

        public void SetSides(int t1, int t2, int t3)
        {
            this.t1 = t1;
            this.t2 = t2;
            this.t3 = t3;
        }

        public int GetT1()
        {
            return this.t1;
        }
        public int GetT2()
        {
            return this.t2;
        }
        public int GetT3()
        {
            return this.t3;
        }
    }
}