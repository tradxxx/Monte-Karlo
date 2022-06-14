using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Monte_Karlo
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Graphics g = CreateGraphics();
            g.DrawRectangle(new Pen(Color.Black,3),50,50,300,300);
            g.DrawEllipse(new Pen(Color.Blue,3),50,50,300,300);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            int insidCount = 0;
            int outsideCount = 0;
            Graphics g2 = CreateGraphics();
            Random r = new Random();
            Pen p1;
            for (int i = 0; i < 10000; i++)
            {
                int rx = r.Next(50, 351);
                int ry = r.Next(50, 351);

                //Центр окружности в точке (200,200)

               

                if (Math.Pow(rx-200,2)+Math.Pow(ry-200,2)<=150*150)
                {
                    p1 = new Pen(Color.Orange);
                    insidCount++;
                }
                else
                {
                    p1 = new Pen(Color.Blue);
                }
                g2.DrawRectangle(p1, rx, ry, 1, 1);

                
            }
            double S = (double)90000 * insidCount / 10000;
            double Pi = (double)Math.Pow(300,2)/Math.Pow(150,2)*insidCount/10000;
            richTextBox1.Text += "S круга = " + S+"\n"+"Pi = "+Pi;
        }

       
    }
}
