using FinelProject_ScreenSaver.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver
{
    delegate void MiddleConsolePosition(object sender, MiddlePositionEventArgs e);

    abstract class Shape : IShape
    {
        #region Date-Members
        public event MiddleConsolePosition ShapeInMiddleOfConsole;
        protected Random rnd = new Random();
        protected int _top;
        protected int _left;
        protected int _width;
        protected int _height;
        protected ConsoleColor _color;
        protected double _area;
        protected double _perimeter;
        protected string _shapeName;
        #endregion

        #region ctors
        public Shape()
        {
            _color = (ConsoleColor)rnd.Next(1, 16);
        }

        public Shape(int top, int left, int width, int height)
        {
            _top = top;
            _left = left;
            _width = width;
            _height = height;
            _color = (ConsoleColor)rnd.Next(1, 16);
        }
        #endregion

        #region Restart-Values-Metod
        /// <summary>
        /// Restart the values of the instance
        /// </summary>
        public void InitWithRandomValues()
        {
            int consoleWidth = Console.WindowWidth;
            int consoleHeight = Console.WindowHeight;
            _width = rnd.Next(5, 20);
            _height = rnd.Next(5, 20);
            _top = rnd.Next(5, consoleHeight - _height);
            _left = rnd.Next(10, consoleWidth - _width);
            _color = (ConsoleColor)rnd.Next(1, 16);
            Console.ForegroundColor = _color;
            this.Draw();
            OnShapeInTheMiddle();
            Console.ResetColor();
            double Area = this.GetArea(ref _area);
            double Perimeter = this.GetPerimeter(ref _perimeter);
            this.ShowDetails(ref Area, ref Perimeter);
            OnShapeInTheMiddle();
        }
        #endregion

        #region Check-If-Event-Will-Raise
        /// <summary>
        /// raise an event
        /// </summary>
        public virtual void OnShapeInTheMiddle()
        {
            // raise event if the shape displayed in the exact middle of the console window
            if (_width == 60 && _height == 15)
            {
                if (ShapeInMiddleOfConsole != null)
                {
                    ShapeInMiddleOfConsole(this, new MiddlePositionEventArgs(3));
                    Thread.Sleep(500);
                }
            }
        }
        #endregion

        #region Draw-Shape-Functio
        /// <summary>
        /// Base Draw metod of the all Draw methods in the classes
        /// </summary>
        public virtual void Draw()
        {
            int top = rnd.Next(5, 50);
            int left = rnd.Next(5, 100);
            Console.SetCursorPosition(left, top);
            int width = rnd.Next(3, 20);
            int height = rnd.Next(3, 20);
        }
        #endregion

        #region Get-Area+Get-Perimeter
        /// <summary>
        /// abstract method that calculate the area of the shape
        /// </summary>
        /// <param name="area">area varible</param>
        /// <returns>area</returns>
        public abstract double GetArea(ref double area);

        /// <summary>
        /// abstract metod that calculate the perimeter of the shape
        /// </summary>
        /// <param name="perimeter">perimeter varible</param>
        /// <returns>perimeter</returns>
        public abstract double GetPerimeter(ref double perimeter);
        #endregion

        #region Show-Details
        /// <summary>
        /// Show shape details
        /// </summary>
        /// <param name="area">area varible</param>
        /// <param name="perimeter">perimeter varible</param>
        public abstract void ShowDetails(ref double area, ref double perimeter);
        #endregion
    }
}