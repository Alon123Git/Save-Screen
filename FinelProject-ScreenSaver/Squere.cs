using FinelProject_ScreenSaver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver
{
    internal class Squere : Shape, ILocalInterface
    {
        #region Ctors
        public Squere() { }

        public Squere(int top, int left, int width, int height) : base(top, left, width, height)
        {
        }
        #endregion

        #region Drae-Squere
        /// <summary>
        /// draw squere
        /// </summary>
        public override void Draw()
        {
            Console.SetCursorPosition(_left, _top);

            for (int i = 0; i < _width; i++)
            {
                Console.CursorLeft = _left;
                for (int j = 0; j < _width; j++)
                {
                    Console.Write("*");
                }
                Console.WriteLine();
            }
        }
        #endregion

        #region Calculate: area, perimeter and show circle details
        /// <summary>
        /// calculate squere area
        /// </summary>
        /// <returns>area</returns>
        public override double GetArea(ref double area)
        {
            area = _width * _height;
            return area;
        }

        /// <summary>
        /// calculate squere perimeter
        /// </summary>
        /// <returns>perimeter</returns>
        public override double GetPerimeter(ref double perimeter)
        {
            perimeter = (_width * 2) + (_height * 2);
            return perimeter;
        }

        /// <summary>
        /// show squere details
        /// </summary>
        /// <param name="area">area varuble</param>
        /// <param name="perimeter">perimeter varible</param>
        public override void ShowDetails(ref double area, ref double perimeter)
        {
            _shapeName = "Squere";
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Area: {0}.\nPerimeter: {1}\ncolor: {2}\nX: {3}\nY: {4}\nShape: {5}"
                , area, perimeter, _color, _left, _top, _shapeName);
        }
        #endregion
    }
}
