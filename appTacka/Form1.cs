using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace appTacka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tacka[] t = new Tacka[30];
        int n = 30;
        Random r = new Random();

        private void Form1_Load(object sender, EventArgs e)
        {
            for(int i=0;i<n;i++)
            {
                int x = r.Next(ClientRectangle.Width);
                int y = r.Next(ClientRectangle.Height);
                t[i] = new Tacka(x, y);

            }
            timer1.Interval = 500;
            timer1.Start();

        }

        private void Form1_Paint(object sender, PaintEventArgs e)
        {
            for (int i = 0; i < n; i++)
            {
                t[i].Crtaj(e.Graphics);

            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (n > 1)
            {
                t[n - 2] = t[n - 2] + t[n - 1];
                n--;
                Refresh();
            }
         
        }
    }
}
