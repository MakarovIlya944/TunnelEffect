using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Tao.FreeGlut;
using Tao.OpenGl;
using Tao.Platform.Windows;

namespace TunnelEffect
{
    public partial class Form2 : Form
    {
        public Oscilation DirFirst = new Oscilation();

        public Form2()
        {
            InitializeComponent();
        }

        private void TimeStep(object sender, EventArgs e)
        {
            
        }
        
        private void Form2_Leave(object sender, EventArgs e)
        {
            timer1.Stop();
        }

        private void Form2_Enter(object sender, EventArgs e)
        {
            timer1.Start();
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics gr = e.Graphics;
            Point[] p1 = new Point[40];
            Point[] p2 = new Point[10];
            Point[] p3 = new Point[10];

            int x = 1;
            gr.DrawLine(Pens.Black, new Point(0, panel1.Height / 2), new Point(panel1.Width, panel1.Height /2));
            gr.DrawLine(Pens.Black, new Point(panel1.Width / 2,0), new Point(panel1.Width/2, panel1.Height));

            int w = panel1.Width, h = panel1.Height;

            for (; x <= w / 2 + w / 4;)
                gr.DrawLine(Pens.Black, new Point(x, (int)DirFirst.DirectWaveRe1(x * 1.0)), new Point(++x, (int)DirFirst.DirectWaveRe1((++x) * 1.0)));

            for (; x <= 7*w / 8;)
                gr.DrawLine(Pens.Black, new Point(x, (int)DirFirst.DirectWaveRe1(x * 1.0)), new Point(++x, (int)DirFirst.DirectWaveRe1((++x) * 1.0)));

            for (; x < w;)
                gr.DrawLine(Pens.Black, new Point(x, (int)DirFirst.DirectWaveRe1(x * 1.0)), new Point(++x, (int)DirFirst.DirectWaveRe1((++x) * 1.0)));
        }
    }

    public class Oscilation
    {
        double A, B, a, b, l;
        public Oscilation()
        {
            A = 0;
            B = 0;
            a = 0;
            b = 0;
            l = 0;
        }

        public Oscilation(double Am, double Bm, double am, double bm, double L)
        {
            A = Am;
            B = Bm;
            a = am;
            b = bm;
            l = L;
        }

        public double DirectWaveRe1(double x)
        {
            return A * Math.Cos(x * a);
        }

        public double DirectWaveIm1(double x)
        {
            return A * Math.Sin(x * a);
        }

        public double ReflecionWaveRe1(double x)
        {
            return B * Math.Sin(x * a);
        }

        public double ReflecionWaveIm1(double x)
        {
            return B * Math.Sin(x * a);
        }

        public double DirectWave2(double x)
        {
            return A * Math.Exp(-b * x);
        }

        public double ReflecWave2(double x)
        {
            return B * Math.Exp(b * x);
        }

        public double DirectWaveRe3(double x)
        {
            return A * Math.Cos(a * (x - l));
        }

        public double DirectWaveIm3(double x)
        {
            return A * Math.Sin(a * (x - l));
        }
    }
}
