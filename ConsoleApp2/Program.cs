using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        class A
        {
            public virtual void M() { Console.Write("A"); }
        }
        class B : A
        {
            public override void M() { Console.Write("B"); }
        }
        class C : B
        {
            new public virtual void M() { Console.Write("C"); }
        }
        class D : C
        {
            public override void M() { Console.Write("D"); }
        }

        static void Main(string[] args)
        {
            D d = new D(); C c = d; B b = c; A a = b;
            d.M(); c.M(); b.M(); a.M();
        }
    }
}
