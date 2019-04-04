using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    public abstract class Shape
    {
        private int x, y;
        private string shapeName = "Undefined";

        public Shape(string shapeName)
        {
            this.shapeName = shapeName;
        }

        public void SetXY(int x, int y)
        {
            this.x = x;
            this.y = y;
        }

        public int X
        {
            get
            {
                return this.x;
            }
            set
            {
                this.x = value;
            }
        }

        public int Y
        {
            get
            {
                return this.y;
            }
            set
            {
                this.y = value;
            }
        }

        public virtual int Area
        {
            get
            {
                return 0;
            }
        }

        public virtual string GetName()
        {
            return shapeName;
        }
    }
}
