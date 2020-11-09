using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrototypeFigure
{
    interface IFigure
    {
        IFigure Clone();
        void GetInfo();
    }
}
