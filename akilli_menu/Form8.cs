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
    public partial class Form8 : Form
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
        public Form8()
        {
            InitializeComponent();
            IntPtr hwnd = this.Handle;
            this.Top = 100;
            this.Left = 250;
        }
        //GERİ DÖNME BUTONU
        private void button1_Click(object sender, EventArgs e)
        {
            Form1 f1 = new Form1();
            f1.ShowDialog();
            this.Close();
        }
        //FORM 8 LOAD
        private void Form8_Load(object sender, EventArgs e)
        {

            SiparisOlustur();
            string yol = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim = "masa01_hesap.txt";
            string tamYol = yol + isim;
            string d = "", c = "", i = "", z = "", p = "", t = "";
            int toplam = 0, sayac = 0;
            string[] lines = File.ReadAllLines(tamYol);

            foreach (string line in lines)
            {
                //DÖNER
                if (sayac >= 0 && sayac <= 8)
                {
                    if (line.Contains('@'))
                    {
                        d += "\n";
                    }
                    else if (line.Contains('?'))
                    {
                        toplam += Convert.ToInt32(line.Trim('?'));
                    }
                    else
                    {
                        d += line;
                        d += "\n";
                    }
                }
                //ÇORBA
                else if (sayac >= 9 && sayac <= 17)
                {
                    if (line.Contains("@"))
                    {
                        c += "\n";
                    }
                    else if (line.Contains('?'))
                    {
                        toplam += Convert.ToInt32(line.Trim('?'));
                    }
                    else
                    {
                        c += line;
                        c += "\n";
                    }
                }
                //IZGARA
                else if (sayac >= 18 && sayac <= 26)
                {
                    if (line.Contains("@"))
                    {
                        i += "\n";
                    }
                    else if (line.Contains('?'))
                    {
                        toplam += Convert.ToInt32(line.Trim('?'));
                    }
                    else
                    {
                        i += line;
                        i += "\n";
                    }
                }
                //ZEYTİNYAĞLI
                else if (sayac >= 27 && sayac <= 35)
                {
                    if (line.Contains("@"))
                    {
                        z += "\n";
                    }
                    else if (line.Contains('?'))
                    {
                        toplam += Convert.ToInt32(line.Trim('?'));
                    }
                    else
                    {
                        z += line;
                        z += "\n";
                    }
                }
                //PİDE
                else if (sayac >= 36 && sayac <= 44)
                {
                    if (line.Contains("@"))
                    {
                        p += "\n";
                    }
                    else if (line.Contains('?'))
                    {
                        toplam += Convert.ToInt32(line.Trim('?'));
                    }
                    else
                    {
                        p += line;
                        p += "\n";
                    }
                }
                //TATLI
                else if (sayac >= 45 && sayac <= 53)
                {
                    if (line.Contains("@"))
                    {
                        t += "\n";
                    }
                    else if (line.Contains('?'))
                    {
                        toplam += Convert.ToInt32(line.Trim('?'));
                    }
                    else
                    {
                        t += line;
                        t += "\n";
                    }
                }
                sayac++;
            }
            label1.Text = d;
            label2.Text = c;
            label3.Text = i;
            label4.Text = z;
            label5.Text = p;
            label6.Text = t;
            label9.Text = toplam.ToString();
        }

    }
}
