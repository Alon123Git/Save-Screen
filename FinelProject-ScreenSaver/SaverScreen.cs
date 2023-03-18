using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver
{
    internal class SaverScreen
    {
        #region Random
        static readonly Random rnd = new Random(); // Random Shape
        #endregion

        #region Start-Function
        /// <summary>
        /// start the save screen function
        /// </summary>
        public static void Start()
        {
            Shape r = new Rectangle();
            r.ShapeInMiddleOfConsole += MiddleShapeSound;
            r.OnShapeInTheMiddle();
            
            while (!Console.KeyAvailable)
            {
                Shape shape;
                int shapeType = rnd.Next(1, 6); // random number between 1 and 5
                switch (shapeType)
                {
                    case 1:
                        shape = new Circle();
                        shape.InitWithRandomValues();
                        break;
                    case 2:
                        shape = new Rectangle();
                        shape.InitWithRandomValues();
                        break;
                    case 3:
                        shape = new Squere();
                        shape.InitWithRandomValues();
                        break;
                    case 4:
                        shape = new HorizontalLine();
                        shape.InitWithRandomValues();
                        break;
                    case 5:
                        shape = new VerticalLine();
                        shape.InitWithRandomValues();
                        break;
                    default:
                        shape = new Circle(); // fallback to default shape
                        break;
                }
                //shape.InitWithRandomValues();
                Thread.Sleep(500); // wait for 1.5 seconds before creating the next shape
                Console.Clear(); // Clear the console window
            }
        }
        #endregion

        #region Event-Method
        /// <summary>
        /// sound beep
        /// </summary>
        /// <param name="sender">parameter of event</param>
        /// <param name="e">varible of the event class</param>
        public static void MiddleShapeSound(object sender, MiddlePositionEventArgs e)
        {
            Console.Beep();
        }
        #endregion
    }
}