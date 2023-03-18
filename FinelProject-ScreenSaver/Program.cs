using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver
{
    internal class Program
    {
        #region Main
        /// <summary>
        /// Main - call the Start function in SaveScreen class
        /// </summary>
        /// <param name="args"></param>
        static void Main(string[] args)
        {
          SaverScreen.Start();
        }
        #endregion
    }
}