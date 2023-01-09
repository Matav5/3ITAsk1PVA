namespace _3ITAsk1_Piskvorky
{
    public partial class Hra : Form
    {
        Policko[,] herniPole;
        public Hra()
        {
            InitializeComponent();
            VytvorHerniPole();
        }

        private void VytvorHerniPole()
        {
            Policko policko;
            herniPole = new Policko[5,5];
            int PolickoWidth = panel1.Width / herniPole.GetLength(1);
            int PolickoHeight = panel1.Height / herniPole.GetLength(0);
            for (int i = 0; i < herniPole.GetLength(0); i++)
            {
                for (int j = 0; j < herniPole.GetLength(1); j++)
                {
                    policko = new Policko();
                    herniPole[i, j] = policko;
                    panel1.Controls.Add(policko);
                    policko.Width = PolickoWidth;
                    policko.Height = PolickoHeight;
                    policko.Location = new Point(policko.Width * j, policko.Height * i);
                }
            }
        }
    }
}