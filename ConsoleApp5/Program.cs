using System;
using System.Collections.Generic;
using System.Data.OleDb;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp5
{
    class Program
    {
        static void Main(string[] args)
        {
            foreach (int i in GetEvens())
                Console.WriteLine(i);
            Console.ReadLine();
        }
        public static IEnumerable<int> GetEvens()
        {
            var integers = new[] { 1, 2, 3, 4, 5, 6, 7, 8 };
            // var result = integers.Where(i => i % 2 == 0).OrderByDescending(i => i).Select(i => new { Result = i });
            var result = (from i in integers
                         where i % 2 == 0
                         orderby i descending
                         select new { Result = i }).ToArray();
            return Array.FindAll(integers, n => n % 2 != 0);
            //foreach (int i in integers)
            //    if (i % 2 == 0)
            //        yield return i;
        }
    }
}
