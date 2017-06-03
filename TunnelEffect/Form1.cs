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
    public partial class Form1 : Form
    {
        public bool GraphicIsOn = false;
        public bool BullIsOn = false;
        public double time = 0, lag = 0;

        public double v = 0.1;
        public double a = 0.05;
        public double x, y, x_;
        public int b = 0;
        public int z_ = -5;

        public Form2 f2;

        TunnelEffect.Experiment main;
        public Form1()
        {
            InitializeComponent();
            ant.InitializeContexts();
        }

        private void ant_Load(object sender, EventArgs e)
        {
            //----------------------------OpenGL-------------------------------
            Glut.glutInit();
            Glut.glutInitDisplayMode(Glut.GLUT_RGB | Glut.GLUT_DOUBLE | Glut.GLUT_DEPTH);

            // отчитка окна 
            Gl.glClearColor(0, 0, 0, 1);

            // установка порта вывода в соответствии с размерами элемента anT 
            Gl.glViewport(0, 0, ant.Width, ant.Height);


            // настройка проекции 
            Gl.glMatrixMode(Gl.GL_PROJECTION);
            Gl.glLoadIdentity();
            Glu.gluPerspective(45, (float)ant.Width / (float)ant.Height, 0.1, 200);
            Gl.glMatrixMode(Gl.GL_MODELVIEW);
            Gl.glLoadIdentity();

            // настройка параметров OpenGL для визуализации 
            Gl.glEnable(Gl.GL_DEPTH_TEST);
            //-----------------------------OpenGL------------------------------

            main = new TunnelEffect.Experiment(1, 1, 1, 1, 1);
        }

        private void TimeStep(object sender, EventArgs e)
        {
            time += timer1.Interval / 1000.0;
            TimeValue.Text = "Время " + Math.Round(time, 3).ToString() + "c";
            if (!BullIsOn)
                lag += timer1.Interval / 1000.0;


            DrawFunction();
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {
            label1.Text = trackBar1.Value.ToString();
        }

        public void DrawFunction()
        {
            Gl.glClear(Gl.GL_COLOR_BUFFER_BIT | Gl.GL_DEPTH_BUFFER_BIT);

            Gl.glLoadIdentity();

            float[] light0_direction = { -2, 1, z_, (float)7 };
            float[] light0_diffuse = { 1, 1, 1 };
            float[] light1_direction = { 2, 1, z_, (float)7 };
            float[] light1_diffuse = { 1, 1, 1 };
            float[] color = { 0.1f, 0.1f, 0.8f, 1 };

            Gl.glEnable(Gl.GL_LIGHTING);
            Gl.glEnable(Gl.GL_LIGHT0);
            Gl.glEnable(Gl.GL_LIGHT1);

            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_DIFFUSE, light0_diffuse);
            Gl.glLightfv(Gl.GL_LIGHT0, Gl.GL_POSITION, light0_direction);

            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_DIFFUSE, light1_diffuse);
            Gl.glLightfv(Gl.GL_LIGHT1, Gl.GL_POSITION, light1_direction);

            Gl.glPushMatrix();//барьер
            Gl.glTranslated(0, 0, z_);
            Rectangle(0, -1, -2, 0.01, 2, 4);
            Gl.glPopMatrix();

            Gl.glPushMatrix();//частица
            Gl.glColor3d(0.1, 1, 0.1);
            if (BullIsOn)
                Gl.glTranslated(-2 + v * time + a * time * time / 2, 0, z_);
            else
                Gl.glTranslated(x_, 0, z_);
            Glut.glutSolidSphere(0.1, 32, 32);
            Gl.glPopMatrix();

            Gl.glFlush();
            ant.Invalidate();
        }

        private void Rectangle(double x, double y, double z, double width, double height, double length)
        {
            Gl.glColor3b(100, 10, 100);
            Gl.glBegin(Gl.GL_QUADS);

            Gl.glVertex3d(x, y, z);//перед
            Gl.glVertex3d(x + width, y, z);
            Gl.glVertex3d(x + width, y + height, z);
            Gl.glVertex3d(x, y + height, z);

            Gl.glVertex3d(x, y + height, z + length);//верх
            Gl.glVertex3d(x + width + 1, y + height, z + length);
            Gl.glVertex3d(x + width, y + height, z);
            Gl.glVertex3d(x, y + height, z);

            Gl.glVertex3d(x, y, z);//лево
            Gl.glVertex3d(x, y, z + length);
            Gl.glVertex3d(x, y + height, z + length);
            Gl.glVertex3d(x, y + height, z);

            Gl.glVertex3d(x + width + 1, y, z + length);//право
            Gl.glVertex3d(x + width, y, z);
            Gl.glVertex3d(x + width, y + height, z);
            Gl.glVertex3d(x + width + 1, y + height, z + length);

            Gl.glVertex3d(x, y, z);//низ
            Gl.glVertex3d(x + width, y, z);
            Gl.glVertex3d(x + width + 1, y, z + length);
            Gl.glVertex3d(x, y, z + length);

            Gl.glVertex3d(x, y, z + length);//зад
            Gl.glVertex3d(x + width + 1, y, z + length);
            Gl.glVertex3d(x + width + 1, y + height, z + length);
            Gl.glVertex3d(x, y + height, z + length);

            Gl.glEnd();
        }

        private void ShowGraphic(object sender, EventArgs e)
        {
            GraphicIsOn = !GraphicIsOn;
            if (GraphicIsOn)
            {
                button2.Text = "Спрятать график";
                f2 = new Form2();
                f2.Show();
                f2.DirFirst = new Oscilation(1, 0.7, 2, 3, 1);
            }
            else
            {
                button2.Text = "Показать график";
                if (f2 != null)
                    f2.Hide();
            }
        }

        private void StarTimer(object sender, EventArgs e)
        {
            timer1.Enabled = !timer1.Enabled;
            if (timer1.Enabled)
                buttonStartTime.Text = "Выключить таймер";
            else
            {
                buttonStartTime.Text = "Включить таймер";
                TimeValue.Text = "Время 0.0с";
                time = 0;
            }
        }
        
    }

    public class Experiment
    {
        const double plankaDjS = 6.626E-34;//Джоуль/сек
        const double plankaEvS = 4.135E-15;//ЭлектроВольт/сек
        const double dirakaDjS = 1.054E-34;//Джоуль/сек
        const double dirakaEvS = 6.582E-16;//ЭлектроВольт/сек

        double mass;
        double energy0;//начальная энергия 
        double energy;//энергия барьера
        double length;

        double a;//(√2m(U0-E))/h
        double b;//(√2mE)/h
        double k;//отношение b/a
        double k2;//k^2

        public int n;//сколько частиц
        List<int> nums;

        bool IsOn;

        public Experiment()
        {
            mass = 0;
            energy = 0;
            energy0 = 0;
            length = 0;
            a = 0;
            b = 0;
            n = 0;
            k = 0;
            k2 = 0;
            IsOn = false;
            nums = new List<int>();
        }
        public Experiment(double m, double E, double E0, double l, int N)//mass, start_energy, energy_barier, length, number_particles
        {
            mass = m;
            energy = E;
            energy0 = E0;
            length = l;
            n = N;
            a = Math.Sqrt(2 * m * E) / dirakaDjS;
            b = Math.Sqrt(2 * m * (E0 - E)) / dirakaDjS;
            k = b / a;
            k2 = E0 / E - 1;
            IsOn = true;
            nums = new List<int>();
        }
        public double GetReflCoef()//Коэффициент прозрачности = вероятность прохождения частицы через барьер
        {
            double e = Math.Exp(-2 * b * length);
            return 16 * k2 * e / Math.Pow((k2 + 1), 2);
        }
        public List<int> MakeRandomNumbers()//Создает массив номеров частиц которые пролетят из n штук частиц
        {
            Random R = new Random();
            double D = GetReflCoef();
            double N = n * D;
            int i = 0, t = 0;
            while (i < N)
            {
                t = (int)(R.Next() % N);
                if (!nums.Contains(t))
                {
                    nums.Add(t);
                    i++;
                }
            }
            return nums;
        }
    }

}