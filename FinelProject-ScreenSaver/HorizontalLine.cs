using FinelProject_ScreenSaver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver
{
    internal class HorizontalLine : Shape, ILocalInterface
    {
        #region Ctors
        public HorizontalLine() { }

        public HorizontalLine(int top, int left, int width, int height) : base(top, left, width, height)
        {
        }
        #endregion

        #region Draw-Horzontal-Line
        /// <summary>
        /// drae horizontal-line
        /// </summary>
        public override void Draw()
        {
            Console.SetCursorPosition(_left, _top);
            for (int i = 0; i <= _width; i++)
            {
                Console.CursorLeft = _left;
                Console.WriteLine("*");
            }
        }
        #endregion

        #region Calculate: area, perimeter and show circle details
        /// <summary>
        /// calculate horizontal-line area
        /// </summary>
        /// <param name="area">area varible</param>
        /// <returns>area</returns>
        public override double GetArea(ref double area)
        {
            return 0;
        }

        /// <summary>
        /// calculate horizontal-line perimeter
        /// </summary>
        /// <returns></returns>
        public override double GetPerimeter(ref double perimeter)
        {
            return _width;
        }

        /// <summary>
        /// show horizontal-line details
        /// </summary>
        /// <param name="area">area varible</param>
        /// <param name="perimeter">perimeter varible</param>
        public override void ShowDetails(ref double area, ref double perimeter)
        {
            _shapeName = "Horizontal-line";
            Console.SetCursorPosition(0, 0);
            Console.WriteLine("Area: {0}.\nPerimeter: {1}\ncolor: {2}\nX: {3}\nY: {4}\nShape: {5}"
                , area, perimeter, _color, _left, _top, _shapeName);
        }
        #endregion
    }
}