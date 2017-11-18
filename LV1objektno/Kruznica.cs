using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV1objektno
{
    class Kruznica : Elipsa
    {
         public Kruznica(bool defaultValues) : base(defaultValues)
        {

        }

        public Kruznica(Color color, Pen pen) : base(color, pen)
        {

        }

        public override void DrawGrafObj(Graphics g, Pen pen, int[] args)
        {
            g.DrawEllipse(pen, args[0], args[1], args[2], args[2]);
        }
    }
}
