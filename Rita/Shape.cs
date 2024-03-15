using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rita
{
    public abstract class Shape
    {
        public string TypeID { get; protected set; }

        public abstract void Draw(Graphics g);
    }
}
