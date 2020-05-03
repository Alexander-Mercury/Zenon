using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Лабаторная_по_Зенону
{
        public partial class Form1 : Form
        {
            public Form1()
            {
                InitializeComponent();
            }
        float t = 0, dt, x = 0, y, vaxil = 0, vtort = 0, d = 0;
        
        private void Form1_Load(object sender, EventArgs e)
            {

            }


        private void timer2_Tick_1(object sender, EventArgs e)
        {
            if (x > 478)
            {
                x = -100;
            }
            if (y > 528)
            {
                y = -50;
            }
            d = Math.Abs (y - x);
            t = d / vaxil;
            dt = t / 20;
            x += vaxil * dt;
            y += vtort * dt;
            pictureBox1.Refresh();
        }

        private void button1_MouseClick_1(object sender, MouseEventArgs e)
        {
            timer2.Start();
            timer2.Interval = 20;
            float.TryParse(textBox1.Text, out vaxil);
            float.TryParse(textBox2.Text, out vtort);
        }


        private void button2_MouseClick_1(object sender, MouseEventArgs e)
        {
            x = 0;
            y = Convert.ToInt32(textBox3.Text);
            if (y == 0)
            {
                MessageBox.Show("Ошибка");
            }
            timer1.Stop();
            timer2.Stop();
        }

        private void timer1_Tick_1(object sender, EventArgs e)
        {
            if (x > 478)
            {
                x = -100;
            }
            if (y > 528)
            {
                y = -50;
            }
            x += (int)vaxil;
            y += (int)vtort;
            pictureBox1.Refresh();
        }


        private void pictureBox1_Paint_1(object sender, PaintEventArgs e)
        {
            Graphics grf = e.Graphics;
            Pen pen1 = new Pen(Color.Green, 3);
            Pen pen2 = new Pen(Color.Blue, 3);
            grf.DrawRectangle(pen1, x, 260, 50, 100);
            grf.DrawEllipse(pen2, y, 310, 50, 50);
        }

        private void Start_MouseClick(object sender, MouseEventArgs e)
            {
                timer1.Start();
                timer1.Interval = 20;
                float.TryParse(textBox1.Text, out vaxil);
                float.TryParse(textBox2.Text, out vtort);
            }
        }
}