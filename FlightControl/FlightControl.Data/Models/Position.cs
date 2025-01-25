using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rychlikapp.stdlibrary.Models
{
    public class Position
    {
        public double X { get; private set; }
        public double Y { get; private set; }

        public Position(double x, double y)
        {
            X = x;
            Y = y;
        }
        public void Change(double x, double y) {
            X = x;Y = y;
        }
    }
}
