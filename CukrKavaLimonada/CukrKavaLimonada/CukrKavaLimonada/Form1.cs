namespace CukrKavaLimonada
{
    public partial class Form1 : Form
    {
        //Náhodný barvy paòáèkù, Koncová èára, Seznam pøeživších
        List<Panacek> panaceks = new List<Panacek>();
        Semafor semafor;
        List<PointF> poziceLouzicek = new List<PointF>();

        List<Panacek> prezivsiPanacci = new List<Panacek>();
        public Form1()
        {
            InitializeComponent();
            semafor = new Semafor(true, pictureBox2.Width, pictureBox2.Height, 1.5f);
            VygenerujChudakyPanacky();
        }

        private void VygenerujChudakyPanacky()
        {
            Random rnd = new Random();
            Panacek panacek;
            for (int i = 0; i < 50; i++)
            {
                panacek = new Panacek(
                     rnd.Next(1, 10),
                     rnd.Next(2) == 1,
                     new PointF(
                         rnd.Next(pictureBox1.Width),
                         pictureBox1.Height - 20
                     )
                );
                panaceks.Add(panacek);

                semafor.onZmenaBarvy += panacek.OnZmenaBarvy;
                panacek.onBrutalneZemrel += this.OnPanacekBrutalneZemrel;
            }
        }

        private void pictureBox1_Paint(object sender, PaintEventArgs e)
        {
            foreach (Panacek panacek in panaceks)
            {
                panacek.Vykresli(e.Graphics);
            }
            foreach (Panacek prezivsiPanacek in prezivsiPanacci)
            {
                prezivsiPanacek.Vykresli(e.Graphics);
            }
            foreach (PointF poziceLouzicky in poziceLouzicek)
            {
                e.Graphics.FillEllipse(Brushes.Red,
                    poziceLouzicky.X - 2.5f,
                    poziceLouzicky.Y - 5,
                    5,
                    10
                    );
            }
            e.Graphics.DrawLine(Pens.Green, new Point(0, 50), new Point(pictureBox1.Width,50)); ;
        }

        private void pictureBox2_Paint(object sender, PaintEventArgs e)
        {
            semafor.Vykresli(e.Graphics);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            List<Panacek> panacciNaOdebrani = new List<Panacek>();
            foreach (Panacek panacek in panaceks)
            {
                panacek.PohniSe();
                if (DostalSeZaCaru(panacek))
                    panacciNaOdebrani.Add(panacek);
            }
            foreach (Panacek panacekNaOdebrani in panacciNaOdebrani)
            {
                panaceks.Remove(panacekNaOdebrani);
            }

            semafor.OdectiCasDoZmeny(timer1.Interval);
            Refresh();
        }

        private bool DostalSeZaCaru(Panacek panacek)
        {
            if(panacek.pozice.Y < 50)
            {
                //Dostal se za èáru
                semafor.onZmenaBarvy -= panacek.OnZmenaBarvy;
                prezivsiPanacci.Add(panacek);
                return true;
            }
            return false;
        }

        public void OnPanacekBrutalneZemrel(Panacek panacek)
        {
            //TODO
            panaceks.Remove(panacek);
            //Vytvoøení loužièky
            PointF poziceLouze = panacek.pozice;
            poziceLouzicek.Add(poziceLouze);
        }
    }
}