using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver
{
    internal class MiddlePositionEventArgs : EventArgs
    {
        #region Data-Member
        public readonly int _middelePosition;
        #endregion

        #region Ctor
        /// <summary>
        /// event ctor
        /// </summary>
        /// <param name="middelePosition">middle position number</param>
        public MiddlePositionEventArgs(int middelePosition)
        {
            _middelePosition = middelePosition;
        }
        #endregion
    }
}
