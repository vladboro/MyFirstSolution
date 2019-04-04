using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Car
    {
        private string model;

        public void SetModel(string model)
        {
            this.model = model;
        }

        public string GetModel()
        {
            return this.model;
        }
    }
}
