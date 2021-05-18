using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Drawing;

namespace appTacka
{
    class Tacka
    {
        private int x, y;
        public int X
        {
            set
            {
                if (value < 0) throw new Exception("x manje od 0");
                else x = value;
                
            }
            get { return x; }

        }
        public int Y
        {
            set
            {
                if (value < 0) throw new Exception("y manje od nula");

            }
            get { return y; }
        }
        public Tacka(int x,int y)
        {
            X = x;
            Y = y;
        }
        public void Crtaj(Graphics g)
        {
            g.FillEllipse(Brushes.Red, x - 2, y - 2, 4, 4);
        }
        public static Tacka operator+(Tacka t1,Tacka t2)
        {
            int x = (t1.x + t2.x) / 2;
            int y = (t1.y + t2.y) / 2;
            return new Tacka(x, y);
        }
    }
}
