using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CukrKavaLimonada
{
    internal class Semafor
    {
        public bool jeZelena;
        public int sirka;
        public int vyska;
        public float casDoZmenyBarvy;
        public Action<bool> onZmenaBarvy;
        public Semafor(bool jeZelena, int sirka, int vyska, float casDoZmenyBarvy)
        {
            this.jeZelena = jeZelena;
            this.sirka = sirka;
            this.vyska = vyska;
            this.casDoZmenyBarvy = casDoZmenyBarvy;
        }
        public void Vykresli(Graphics g)
        {
            g.FillEllipse(jeZelena ? Brushes.DarkRed : Brushes.Red , 0, 0, sirka/2, vyska);
            g.FillEllipse(jeZelena ? Brushes.Lime : Brushes.DarkOliveGreen, sirka/2, 0, sirka/2, vyska);
        }

        internal void OdectiCasDoZmeny(int interval)
        {
            casDoZmenyBarvy -= interval/1000f;
            //Zmena barvy etc etc.
            if(casDoZmenyBarvy <= 0)
            {
                ZmenBarvu();
            }
        }

        private void ZmenBarvu()
        {
            jeZelena = !jeZelena;
            Random rnd = new Random();
            casDoZmenyBarvy = (float)(rnd.NextDouble() + 0.5);
            onZmenaBarvy.Invoke(jeZelena);
            //To be continued
        }
    }
}
