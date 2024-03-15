using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rita
{
    internal class Triangle : Shape
    {
        public override void Draw(Graphics graphics, Pen pen)
        {
            // Calculate the base of the triangle
            int baseLength = Math.Abs(EndPoint.X - StartPoint.X);

            // Calculate the height of the triangle
            int height = (int)(baseLength * Math.Sqrt(3) / 2);

            // Determine the direction of the triangle based on start and end points
            bool isRight = EndPoint.X > StartPoint.X;

            // Calculate the vertices of the triangle
            Point p1 = StartPoint;
            Point p2 = new Point(StartPoint.X + (isRight ? baseLength : -baseLength), StartPoint.Y);
            Point p3;

            if (isRight)
            {
                // If drawing to the right, apex is above the start point
                p3 = new Point(StartPoint.X + baseLength / 2, StartPoint.Y - height);
            }
            else
            {
                // If drawing to the left, apex is above the end point
                p3 = new Point(StartPoint.X - baseLength / 2, StartPoint.Y - height);
            }

            // Draw the triangle
            graphics.DrawLine(pen, p1, p2);
            graphics.DrawLine(pen, p2, p3);
            graphics.DrawLine(pen, p3, p1);
        }
    }
}
