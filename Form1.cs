namespace Degiskenler_Double
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            string ad, soyad;
            double sinav1, sinav2, proje;
            double ortalama;
            ad = textBox1.Text;
            soyad = textBox2.Text;
            sinav1 = Convert.ToDouble(textBox3.Text);
            sinav2 = Convert.ToDouble(textBox4.Text);
            proje = Convert.ToDouble(textBox5.Text);
            ortalama = (sinav1 + sinav2 + proje) / 3;
            listBox1.Items.Add(ad + " " + soyad + " " + " Ortalama: " + ortalama);
        }
    }
}