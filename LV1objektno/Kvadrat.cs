using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV1objektno
{
    class Kvadrat : Linija
    {
        
        public Kvadrat(bool defaultValues) : base(defaultValues)
        {

        }

        public Kvadrat(Color color, Pen pen) : base (color, pen)
        {

        }

        public override void DrawGrafObj(Graphics g, Pen pen, int[] args)
        {
            g.DrawRectangle(pen, args[0], args[1], args[2], args[3]);
        }

    }
}
