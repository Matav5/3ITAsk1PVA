namespace _3ITAsk1Ctverecky
{
    public partial class Form1 : Form
    {
        int pocitadlo = 0;
        public Form1()
        {
            InitializeComponent();
        }

        private void panel1_MouseClick(object sender, MouseEventArgs e)
        {
            Ctverecek ctverecek = null;
            if(e.Button== MouseButtons.Left)
            {
                ctverecek = new VtipnyCtverecek();
            }
            else if(e.Button== MouseButtons.Right)
            {
                ctverecek = new ZvetsovaciCtverecek();
            }

            if (ctverecek != null)
            {
                ctverecek.Location = new Point(e.X, e.Y);
                panel1.Controls.Add(ctverecek);
                button1.MouseClick += ctverecek.Ctverecek_MouseClick;
                ctverecek.onCtverecekClicked += Ctverecek_OnClicked;
            }
        }

        private void Ctverecek_OnClicked(Ctverecek ctverecek)
        {
            pocitadlo++;
            label1.Text = "Poèet kliknutí: " + pocitadlo;
        }

        private void button1_MouseClick(object sender, MouseEventArgs e)
        {
            
        }
    }
}