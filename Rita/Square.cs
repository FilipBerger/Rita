using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rita
{
    public class Square : Shape
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            // Calculate the size of the square based on the StartPoint and EndPoint
            int sideLength = Math.Max(Math.Abs(EndPoint.X - StartPoint.X), Math.Abs(EndPoint.Y - StartPoint.Y));

            // Create a rectangle to represent the square's bounds
            Rectangle square = new Rectangle(StartPoint.X, StartPoint.Y, sideLength, sideLength);

            // Adjust the rectangle if dragging to the left or upwards
            if (EndPoint.X < StartPoint.X)
            {
                square.X = StartPoint.X - sideLength;
            }
            if (EndPoint.Y < StartPoint.Y)
            {
                square.Y = StartPoint.Y - sideLength;
            }

            // Draw the square
            graphics.DrawRectangle(pen, square);
        }
    }
}

