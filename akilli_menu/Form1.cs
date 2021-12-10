using System;
using System.Threading;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace akilli_menu
{
    public partial class Form1 : Form
    {
        List<string> hesapy = new List<string>(100);
        //SİPARİŞ OLUŞTURMA
        public void SiparisOlustur()
        {
            string yol = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim = "masa01_hesap.txt";
            string tamYol = yol + isim;
            string yol1 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim1 = "masa01_doner.txt";
            string tamYol1 = yol1 + isim1;
            string yol2 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim2 = "masa01_corba.txt";
            string tamYol2 = yol2 + isim2;
            string yol3 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim3 = "masa01_izgara.txt";
            string tamYol3 = yol3 + isim3;
            string yol4 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim4 = "masa01_zeytinyagli.txt";
            string tamYol4 = yol4 + isim4;
            string yol5 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim5 = "masa01_pide.txt";
            string tamYol5 = yol5 + isim5;
            string yol6 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim6 = "masa01_tatli.txt";
            string tamYol6 = yol6 + isim6;

            foreach (string line in File.ReadAllLines(tamYol1))
            {
                if (!(line == " "))
                {
                    hesapy.Add(line);
                }
            }
            foreach (string line in File.ReadAllLines(tamYol2))
            {
                if (!(line == " "))
                {
                    hesapy.Add(line);
                }
            }
            foreach (string line in File.ReadAllLines(tamYol3))
            {
                if (!(line == " "))
                {
                    hesapy.Add(line);
                }
            }
            foreach (string line in File.ReadAllLines(tamYol4))
            {
                if (!(line == " "))
                {
                    hesapy.Add(line);
                }
            }
            foreach (string line in File.ReadAllLines(tamYol5))
            {
                if (!(line == " "))
                {
                    hesapy.Add(line);
                }
            }
            foreach (string line in File.ReadAllLines(tamYol6))
            {
                if (!(line == " "))
                {
                    hesapy.Add(line);
                }
            }
            File.WriteAllLines(tamYol, hesapy);
        }
        public Form1()
        {
            InitializeComponent();
            IntPtr hwnd = this.Handle;
            this.Top = 100;
            this.Left = 250;
        }
        //FORM 1 LOAD
        private void Form1_Load(object sender, EventArgs e)
        {

        }
        //FORM 2 DÖNER
        private void button1_Click(object sender, EventArgs e)
        {
            Form2 f2 = new Form2();
            f2.ShowDialog();
            this.Close();
        }
        //FORM 3 ÇORBA
        private void button2_Click(object sender, EventArgs e)
        {
            Form3 f3 = new Form3();
            f3.ShowDialog();
            this.Close();
        }
        //FORM 4 IZGARA
        private void button3_Click(object sender, EventArgs e)
        {
            Form4 f4 = new Form4();
            f4.ShowDialog();
            this.Close();
        }
        //FORM 5 ZEYTİNYAĞLI
        private void button4_Click(object sender, EventArgs e)
        {
            Form5 f5 = new Form5();
            f5.ShowDialog();
            this.Close();
        }
        //FORM 6 PİDE
        private void button5_Click(object sender, EventArgs e)
        {
            Form6 f6 = new Form6();
            f6.ShowDialog();
            this.Close();
        }
        //FORM 7 TATLI
        private void button6_Click(object sender, EventArgs e)
        {
            Form7 f7 = new Form7();
            f7.ShowDialog();
            this.Close();
        }
        //FORM 8 SİPARİŞİ GÖRME
        private void button8_Click(object sender, EventArgs e)
        {
            Form8 f8 = new Form8();
            f8.ShowDialog();
            this.Close();
        }
        //SİPARİŞİ SİLME
        private void button9_Click(object sender, EventArgs e)
        {
            string yol = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim = "masa01_hesap.txt";
            string tamYol = yol + isim;
            string yol1 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim1 = "masa01_doner.txt";
            string tamYol1 = yol1 + isim1;
            string yol2 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim2 = "masa01_corba.txt";
            string tamYol2 = yol2 + isim2;
            string yol3 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim3 = "masa01_izgara.txt";
            string tamYol3 = yol3 + isim3;
            string yol4 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim4 = "masa01_zeytinyagli.txt";
            string tamYol4 = yol4 + isim4;
            string yol5 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim5 = "masa01_pide.txt";
            string tamYol5 = yol5 + isim5;
            string yol6 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim6 = "masa01_tatli.txt";
            string tamYol6 = yol6 + isim6;
            var mesaj = MessageBox.Show("SİPARİŞ SİLİNSİNMİ", "", MessageBoxButtons.YesNo);
            if (mesaj.ToString() == "Yes")
            {
                hesapy.Clear();
                string yazilacak = " ";
                hesapy.Add(yazilacak);
                File.WriteAllLines(tamYol, hesapy);
                File.WriteAllLines(tamYol1, hesapy);
                File.WriteAllLines(tamYol2, hesapy);
                File.WriteAllLines(tamYol3, hesapy);
                File.WriteAllLines(tamYol4, hesapy);
                File.WriteAllLines(tamYol5, hesapy);
                File.WriteAllLines(tamYol6, hesapy);
                MessageBox.Show("SİPARİŞ SİLİNDİ", "", MessageBoxButtons.OK);
            }
        }
        //SİPARİŞİ GÖNDERME
        private void button7_Click(object sender, EventArgs e)
        {
            SiparisOlustur();
            string yol = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim = "masa01_hesap.txt";
            string tamYol = yol + isim;
            string yol1 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim1 = "masa01_doner.txt";
            string tamYol1 = yol1 + isim1;
            string yol2 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim2 = "masa01_corba.txt";
            string tamYol2 = yol2 + isim2;
            string yol3 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim3 = "masa01_izgara.txt";
            string tamYol3 = yol3 + isim3;
            string yol4 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim4 = "masa01_zeytinyagli.txt";
            string tamYol4 = yol4 + isim4;
            string yol5 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim5 = "masa01_pide.txt";
            string tamYol5 = yol5 + isim5;
            string yol6 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim6 = "masa01_tatli.txt";
            string tamYol6 = yol6 + isim6;
            var mesaj = MessageBox.Show("SİPARİŞ GÖNDERİLSİNMİ?", "", MessageBoxButtons.YesNo);
            if (mesaj.ToString() == "Yes")
            {
                hesapy.Clear();
                string yazilacak = " ";
                hesapy.Add(yazilacak);
                File.WriteAllLines(tamYol, hesapy);
                File.WriteAllLines(tamYol1, hesapy);
                File.WriteAllLines(tamYol2, hesapy);
                File.WriteAllLines(tamYol3, hesapy);
                File.WriteAllLines(tamYol4, hesapy);
                File.WriteAllLines(tamYol5, hesapy);
                File.WriteAllLines(tamYol6, hesapy);
                MessageBox.Show("SİPARİŞ GÖNDERİLDİ?", "", MessageBoxButtons.OK);
            }
        }
        //GARSON ÇAĞIRMA
        private void button10_Click(object sender, EventArgs e)
        {
            MessageBox.Show("GARSON ÇAĞIRILDI", "", MessageBoxButtons.OK);
        }
    }
}
