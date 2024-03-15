using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Rita
{
    public class Circle : Shape
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            // Calculate the dimensions of the circle based on StartPoint and EndPoint
            var radius = (int)Math.Sqrt(Math.Pow(EndPoint.X - StartPoint.X, 2) + Math.Pow(EndPoint.Y - StartPoint.Y, 2));
            var rectangle = new Rectangle(StartPoint.X - radius, StartPoint.Y - radius, radius * 2, radius * 2);

            // Draw the circle
            graphics.DrawEllipse(pen, rectangle);
        }
    }
}
