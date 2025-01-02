using System;
using System.Drawing;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            yenihiz = hiz.Next(5, 10);
            yeniyukseklik = yükseklik.Next(0, 400);
        }
        
        Random hiz = new Random();
        Random yükseklik = new Random();

        int yenihiz = 0;
        int yeniyukseklik = 0;

        int sayac = 1;

        private void button1_Click(object sender, EventArgs e) //Uygulamanın main formunu tekrar başlatmak için
        {
            if (sayac % 2 == 0)
            {
                if (Application.OpenForms[0] == this) //Uygulamanin main form'u
                {
                    Application.Restart();
                }
                else
                {
                    Form1 f = new Form1();
                    f.Show();
                    this.Close();
                }
            }
            else
            {
                button1.Text = "TEKRAR";
                
                timer1.Enabled = true;
            }
            sayac++;

        }

        int k = 1;
        int j = 1;
        byte i = 1;
        double L = 0;

        private void timer1_Tick(object sender, EventArgs e)
        {
            int yukseklik = 675 - yeniyukseklik; //Yukarı çıktıkça yüksekliğin artması için
            while (i == 1) //1 kere çalışıyor bu sayede yükseklik 1 kere belirleniyor
            {
                pictureBoxUcak.Top += yeniyukseklik;
                pictureBoxBomba.Top += yeniyukseklik;

                textBoxhiz.Text = Convert.ToString(yenihiz) + " Km/h";
                textBoxyukseklik.Text = Convert.ToString(yukseklik) + " m";

                i++;
            }

            pictureBoxUcak.Left += yenihiz ; //Uçağın sağa doğru hareket etmesi için
            pictureBoxBomba.Left += yenihiz;

            if (pictureBoxBomba.Location.Y > 570) //Bomba yere düştüğünde yatayda durması için
            {
                pictureBoxBomba.Left -= yenihiz;
            }

            int x1 = 15 + pictureBox2.Location.X; //hedefkoordinatx
            int y1 = 660 - pictureBox2.Location.Y; //hedefkoordinaty

            int x2 = 75 + pictureBoxUcak.Location.X; //bombakoordinatx
            int y2 = 645 - pictureBoxUcak.Location.Y; //bombakoordinaty

            L =  Math.Sqrt(Math.Pow((y2 - y1), 2) + Math.Pow((x2 - x1), 2)); //Lazer mesafesi
            
            textBoxL.Text = Convert.ToString(L);

            if (pictureBoxUcak.Location.X > 550 && pictureBoxUcak.Location.X < 650)
            {
                ATES.BackColor = Color.Red;
            }
            else
            {
                ATES.BackColor = Color.White;
            }

            while (pictureBoxBomba.Location.X > 855 && pictureBoxBomba.Location.X < 1150 && pictureBoxBomba.Location.Y > 570 && j == 1)
            {
                textBox1.BackColor = Color.Green;
                textBox1.Text = "BAŞARILI";
                j = j + 1;
            }

            while (pictureBoxBomba.Location.X < 855 && pictureBoxBomba.Location.Y > 570 && k == 1)
            {
                textBox1.BackColor = Color.Red;
                textBox1.Text = "BAŞARISIZ";
                k = k + 1;
            }

            if (pictureBoxUcak.Left > pictureBox1.Right) //Uçak formun sonuna geldiğinde timer1 sonlanıyor
            {
                timer1.Stop();
            }
        }

        private void ATES_Click(object sender, EventArgs e)
        {
            timer2.Enabled = true;
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            pictureBoxBomba.Top += 1; //Bobanın düşmesi için

            if (pictureBoxBomba.Location.Y > 575) //Bombanın yere düşünce düşeyde durması için
            {
                pictureBoxBomba.Top -= 1;

                string yol = "D:/DERSLER/3-İnternet Tabanlı Programlama/Documantes/odev_1/ornek/FÜZE.jpg";
                pictureBoxBomba.Image = Image.FromFile(yol);
            }
            if (pictureBoxUcak.Left > pictureBox1.Right) //Uçak formun sonuna geldiğinde timer1 sonlanıyor
            {
                timer2.Stop();
            }
        }
    }
}