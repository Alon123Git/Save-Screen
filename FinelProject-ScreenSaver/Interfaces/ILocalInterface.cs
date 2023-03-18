using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinelProject_ScreenSaver.Interfaces
{
    internal interface ILocalInterface
    {
        #region Signatures-Of-Functions
        void Draw();

        double GetArea(ref double area);

        double GetPerimeter(ref double perimeter);

        void ShowDetails(ref double area, ref double perimeter);
        #endregion
    }
}
