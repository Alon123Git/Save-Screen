using FinelProject_ScreenSaver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver
{

    internal class Rectangle : Shape, ILocalInterface
    {
        #region Ctors
        public Rectangle() { }

        public Rectangle(int top, int left, int width, int height) : base(top, left, width, height)
        {
        }
        #endregion

        #region Draw-Rectangle
        /// <summary>
        /// draw rectangle
        /// </summary>
        public override void Draw()
        {
            Console.SetCursorPosition(_left, _top);

            for (int i = 0; i < _height; i++)
            {
                Console.CursorLeft = _left;
                Console.CursorTop = _top + i;
                for (int j = 0; j < _width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
                Console.CursorTop++;
            }
        }
#endregion

        #region Calculate: area, perimeter and show circle details
        /// <summary>
        /// calculate rectangle area
        /// </summary>
        /// <returns>area</returns>
        public override double GetArea(ref double area)
        {
            int summery = _width * _height;
            return summery;
        }

        /// <summary>
        /// calculate rectangle perimeter
        /// </summary>
        /// <returns>perimeter</returns>
        public override double GetPerimeter(ref double perimeter)
        {
            perimeter = (_width * 2) + (_height * 2);
            return perimeter;
        }

        /// <summary>
        /// show rectangle details
        /// </summary>
        /// <param name="area">area varible</param>
        /// <param name="perimeter">perimeter varible</param>
        public override void ShowDetails(ref double area, ref double perimeter)
        {
            _shapeName = "Rectangle";
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Area: {0}.\nPerimeter: {1}\ncolor: {2}\nX: {3}\nY: {4}\nShape: {5}"
                , area, perimeter, _color, _left, _top, _shapeName);
        }
        #endregion
    }
}
