using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LV1objektno
{
    public partial class Form1 : Form
    {
        Color color;
        Pen pen;
        Graphics g;
        Linija li = new Linija(true);
        Kvadrat kv = new Kvadrat(true);
        Elipsa el = new Elipsa(true);
        Kruznica kr = new Kruznica(true);
        Poligon po = new Poligon(true);
        int[] draw;
        public Point StartPoint;
        bool bMouseDown;


        Point[] points = new Point[5];
        



        public Form1()
        {
            InitializeComponent();
            g = this.CreateGraphics();
            bMouseDown = false;
            color = Color.Pink;


        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

        }

        private void Form1_MouseDown(object sender, MouseEventArgs e)
        {
            if (radioButton6.Checked)
            {
                color = Color.Black;
            }
            if (radioButton7.Checked)
            {
                color = Color.Red;
            }

            if (radioButton8.Checked)
            {
                color = Color.Blue;
            }

            pen = new Pen(color, 3);

 

            if (!bMouseDown)
            {
                if (radioButton1.Checked  || radioButton2.Checked || radioButton3.Checked) draw = new int[4];
                else if (radioButton4.Checked) draw = new int[3];
                else if (radioButton5.Checked)
                {      
                    bMouseDown = true;
                }

                StartPoint = e.Location;
                draw[0] = e.X;
                draw[1] = e.Y;

            }

            else
            {
                po.DrawGrafObj(g, pen, draw);

            }

        }

        private void Form1_MouseUp(object sender, MouseEventArgs e)
        {

            if (radioButton1.Checked) //LINIJA
            {

                draw[2] = e.X;
                draw[3] = e.Y;
                li.DrawGrafObj(g, pen, draw);

            }

            if (radioButton2.Checked) //KVADRAT
            {
                if (e.X > StartPoint.X && e.Y > StartPoint.Y)
                {
                    draw[2] = e.X - StartPoint.X;
                    draw[3] = e.Y - StartPoint.Y;
                }
                else if (e.X > StartPoint.X && e.Y < StartPoint.Y)
                {
                    draw[1] -= StartPoint.Y - e.Y;
                    draw[2] = e.X - StartPoint.X;
                    draw[3] = StartPoint.Y - e.Y;
                }

                else if (e.X < StartPoint.X && e.Y > StartPoint.Y)
                {

                    draw[0] -= StartPoint.X - e.X;
                    draw[2] = StartPoint.X - e.X;
                    draw[3] = e.Y - StartPoint.Y;
                }

                else
                {
                    draw[0] -= StartPoint.X - e.X;
                    draw[1] -= StartPoint.Y - e.Y;
                    draw[2] = StartPoint.X - e.X;
                    draw[3] = StartPoint.Y - e.Y;
                }


                kv.DrawGrafObj(g, pen, draw);

            }

            if (radioButton3.Checked)//ELIPSA
            {
                if (e.X > StartPoint.X && e.Y > StartPoint.Y)
                {
                    draw[2] = e.X - StartPoint.X;
                    draw[3] = e.Y - StartPoint.Y;
                }

                else if (e.X > StartPoint.X && e.Y < StartPoint.Y)
                {
                    draw[1] -= StartPoint.Y - e.Y;
                    draw[2] = e.X - StartPoint.X;
                    draw[3] = StartPoint.Y - e.Y;
                }

                else if (e.X < StartPoint.X && e.Y > StartPoint.Y)
                {

                    draw[0] -= StartPoint.X - e.X;
                    draw[2] = StartPoint.X - e.X;
                    draw[3] = e.Y - StartPoint.Y;
                }

                else
                {
                    draw[0] -= StartPoint.X - e.X;
                    draw[1] -= StartPoint.Y - e.Y;
                    draw[2] = StartPoint.X - e.X;
                    draw[3] = StartPoint.Y - e.Y;
                }
                el.DrawGrafObj(g, pen, draw);
            }

            if (radioButton4.Checked) //KRUZNICA
            {
                if (e.X > StartPoint.X && e.Y > StartPoint.Y)
                {
                    draw[2] = e.X - StartPoint.X;
                }

                else if (e.X > StartPoint.X && e.Y < StartPoint.Y)
                {
                    draw[1] -= StartPoint.Y - e.Y;
                    draw[2] = e.X - StartPoint.X;

                }

                else if (e.X < StartPoint.X && e.Y > StartPoint.Y)
                {

                    draw[0] -= StartPoint.X - e.X;
                    draw[2] = StartPoint.X - e.X;

                }

                else
                {
                    draw[0] -= StartPoint.X - e.X;
                    draw[1] -= StartPoint.Y - e.Y;
                    draw[2] = StartPoint.X - e.X;
                }


                kr.DrawGrafObj(g, pen, draw);
            }

          

        }

        private void Form1_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Form1_MouseMove(object sender, MouseEventArgs e)
        {

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
           
        }


    }
}
