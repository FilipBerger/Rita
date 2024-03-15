using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rita
{
    public class Elipse : Shape
    {
        public Elipse() 
        {
            TypeID = "Elipse";
        }

        public override void Draw(Graphics g)
        {
            throw new NotImplementedException();
        }
    }
}
