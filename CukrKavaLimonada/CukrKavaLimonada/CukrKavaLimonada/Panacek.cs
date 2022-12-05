using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukrKavaLimonada
{
    public class Panacek
    {
        public float rychlost;
        public bool bezi;
        public PointF pozice;
        public Action<Panacek> onBrutalneZemrel;
        public Brush stetec;
        public Panacek(float rychlost, bool bezi, PointF pozice)
        {
            this.rychlost = rychlost;
            this.bezi = bezi;
            this.pozice = pozice;
            Random r = new Random();
            Color color = Color.FromArgb(r.Next(256), r.Next(256), r.Next(256));
            stetec = new SolidBrush(color);
        }
        public void Vykresli(Graphics g)
        {
            g.FillEllipse(stetec, pozice.X - 5, pozice.Y - 5, 10, 10);
        }

        internal void PohniSe()
        {
            if (bezi)
            {
                pozice.Y -= rychlost;
            }
        }
        public void OnZmenaBarvy(bool jeZelena)
        {
            Random rnd = new Random();
            //20%
            if (rnd.Next(10) > 1)
            {

                if (jeZelena)
                {
                    bezi = true;
                }
                else
                {
                    bezi = false;
                }
            }
            else
            {
                if (!jeZelena)
                {
                    //Umri
                    //TODO
                    if(onBrutalneZemrel != null)
                        onBrutalneZemrel.Invoke(this);
                }
            }
        }
    }
}
