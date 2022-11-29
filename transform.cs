using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp9
{
    internal class transform
    {
        public PointF pos;
        public Size size;
        public transform (PointF position, Size si)
        {
            pos = position;
            size = si;
        }
    }
}
