using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV1objektno
{

    class Poligon : GrafObj
    {
        public Poligon(bool defaultValues) : base(defaultValues)
        {

        }

        public Poligon(Color color, Pen pen) : base(color, pen)
        {

        }

        public override void DrawGrafObj(Graphics g, Pen pen, int[] args)
        {
         
         Point[] points = new Point[10];
         
         Random r = new Random();
         for (int x = 0; x < 5; x++ )
         {
             points[x].X = r.Next(0, 500);
             points[x].Y = r.Next(0, 200);
         }

            g.DrawPolygon(pen, points);

        }
    }
}
