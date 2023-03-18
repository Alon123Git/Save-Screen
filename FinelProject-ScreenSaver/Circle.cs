using FinelProject_ScreenSaver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Policy;
using System.Text;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver
{
    internal class Circle : Shape, ILocalInterface
    {
        #region Data-Member
        private int _radius;
        #endregion

        #region Ctors
        public Circle() { }

        public Circle(int top, int left, int width, int height) : base(top, left, width, height)
        {
        }
        #endregion

        #region Draw-Circle
        /// <summary>
        /// draw circle
        /// </summary>
        public override void Draw()
        {
            Console.SetCursorPosition(_left, _top);
            _radius = rnd.Next(5, 11);
            int diameter = _radius * 2;
            int centerX = diameter / 2;
            int centerY = diameter / 2;

            for (int i = 0; i < diameter; i++)
            {
                int row = _top + i;
                if (row < 0 || row >= Console.WindowHeight) continue;

                Console.CursorLeft = _left;
                for (int j = 0; j < diameter; j++)
                {
                    int col = _left + j;
                    if (col < 0 || col >= Console.WindowWidth) continue;

                    double distance = Math.Sqrt(Math.Pow(i - centerX, 2) + Math.Pow(j - centerY, 2));
                    if (distance <= _radius)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Calculate: area, perimeter and show circle details
        /// <summary>
        /// calculate circle area
        /// </summary>
        /// <returns>area</returns>
        public override double GetArea(ref double area)
        {
            area = Math.PI * Math.Pow(_radius, 2);
            return Math.Round(area, 3); // round to 3 double places
        }


        /// <summary>
        /// calculate circle perimeter
        /// </summary>
        /// <returns>perimeter</returns>
        public override double GetPerimeter(ref double perimeter)
        {
            perimeter = (double)(2 * Math.PI * _radius);
            return Math.Round(perimeter, 3); // round to 3 double places
        }

        /// <summary>
        /// show circle details
        /// </summary>
        /// <param name="area">area varible</param>
        /// <param name="perimeter">perimeter varible   </param>
        public override void ShowDetails(ref double area, ref double perimeter)
        {
            _shapeName = "Circle";
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Area: {0}.\nPerimeter: {1}\ncolor: {2}\nradius: {3}\nX: {4}\nY: {5}\nShape: {6}"
                ,area, perimeter, _color, _radius, _left, _top, _shapeName);
        }
        #endregion
    }
}
