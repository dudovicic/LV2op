using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace LV1objektno
{
    class GrafObj
    {
        public Color boja { get; set; }

        public GrafObj(bool defaultValues)
        {
            if(defaultValues)
            {
                boja = Color.Black;
            }
        }

        public GrafObj(Color color, Pen pen)
        {
            this.boja = color;
           
        }

      
        public virtual void DrawGrafObj(Graphics g, Pen pen, int [] args)
        {
           
        }

    }
}
