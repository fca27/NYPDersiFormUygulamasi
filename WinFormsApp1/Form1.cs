namespace WinFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        Sinema sinema1 = new Sinema();
        private void buttonOluþtur_Click(object sender, EventArgs e)
        {
            
            sinema1.sinemaAdý = textBoxSalon.Text;
            string koltukSayisi = textBoxKoltukSayisi.Text;
            sinema1.koltukSayisi = Convert.ToInt32(koltukSayisi);
        }

        private void buttonBiletSat_Click(object sender, EventArgs e)
        {
            sinema1.BiletSat();            
            label3.Text = sinema1.sinemaAdý+sinema1.BiletSat().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            sinema1.BiletIptal();
            label3.Text = sinema1.sinemaAdý + sinema1.BiletIptal().ToString();
        }

        
    }
}