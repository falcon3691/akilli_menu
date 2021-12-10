﻿using System;
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
    public partial class Form4 : Form
    {
    
        int a1, a2, a3, a4, a5, sayac;
        float b1, b2, b3, b4, b5, sonuc;
        List<string> yemek = new List<string>(100);
        List<string> hesapy = new List<string>(100);
        public Form4()
        {
            InitializeComponent();
            IntPtr hwnd = this.Handle;
            this.Top = 100;
            this.Left = 250;
        }
        //FORM 4 LOAD
        private void Form4_Load(object sender, EventArgs e)
        {
            label12.Text = a1.ToString();
            label17.Text = b1.ToString();
            label13.Text = a2.ToString();
            label18.Text = b2.ToString();
            label14.Text = a3.ToString();
            label19.Text = b3.ToString();
            label15.Text = a4.ToString();
            label20.Text = b4.ToString();
            label16.Text = a5.ToString();
            label21.Text = b5.ToString();
        }
        //GERİ DÖNME BUTONU
        private void button6_Click(object sender, EventArgs e)
        {
            hesapy.Clear();
            yemek.Clear();
            Form1 f1 = new Form1();
            this.Close();
            f1.ShowDialog();
        }
        //GERİ ALMA BUTONU
        private void button7_Click(object sender, EventArgs e)
        {
            string a;
            sayac = 0;
            foreach (string yazi in yemek)
                sayac++;
            try
            {
                a = yemek[sayac - 1];
                yemek.RemoveAt(sayac - 1);

                switch (a)
                {
                    case "Adana Kebap":
                        a1--;
                        b1 -= 25;
                        label12.Text = a1.ToString();
                        label17.Text = b1.ToString();
                        sonuc = b1 + b2 + b3 + b4 + b5;
                        label24.Text = sonuc.ToString();
                        break;
                    case "Urfa Kebap":
                        a2--;
                        b2 -= 25;
                        label13.Text = a2.ToString();
                        label18.Text = b2.ToString();
                        sonuc = b1 + b2 + b3 + b4 + b5;
                        label24.Text = sonuc.ToString();
                        break;
                    case "Kuzu Şiş":
                        a3--;
                        b3 -= 30;
                        label14.Text = a3.ToString();
                        label19.Text = b3.ToString();
                        sonuc = b1 + b2 + b3 + b4 + b5;
                        label24.Text = sonuc.ToString();
                        break;
                    case "Lüfer":
                        a4--;
                        b4 -= 20;
                        label15.Text = a4.ToString();
                        label20.Text = b4.ToString();
                        sonuc = b1 + b2 + b3 + b4 + b5;
                        label24.Text = sonuc.ToString();
                        break;
                    case "Tavuk Kanat":
                        a5--;
                        b5 -= 30;
                        label16.Text = a5.ToString();
                        label21.Text = b5.ToString();
                        sonuc = b1 + b2 + b3 + b4 + b5;
                        label24.Text = sonuc.ToString();
                        break;
                    default:
                        break;
                }
            }
            catch
            {
                Console.WriteLine(" ");
            }
        }
        //HESABA EKLEME BUTONU
        private void button8_Click(object sender, EventArgs e)
        {
            string yol1 = @"C:\Users\ACER\Desktop\KODLAMA\Visual Studio\akilli_menu\Masalar\";
            string isim1 = "masa01_izgara.txt";
            string tamYol1 = yol1 + isim1;
            hesapy.Clear();
            string yazilacak = "IZGARALAR\n" +
                               "--------\n" +
                               "Adana Kebap     " + a1.ToString() + "   " + b1.ToString() + "TL\n" +
                               "Urfa Kebap         " + a2.ToString() + "   " + b2.ToString() + "TL\n" +
                               "Kuzu Şiş             " + a3.ToString() + "   " + b3.ToString() + "TL\n" +
                               "Lüfer                   " + a4.ToString() + "   " + b4.ToString() + "TL\n" +
                               "Tavuk Kanat        " + a5.ToString() + "   " + b5.ToString() + "TL\n" +
                               "?" + sonuc.ToString() +
                               "\n@";
            hesapy.Add(yazilacak);

            File.WriteAllLines(tamYol1, hesapy);
        }
        private void button1_Click(object sender, EventArgs e)
        {
            a1++;
            b1 += 25;
            label12.Text = a1.ToString();
            label17.Text = b1.ToString();
            sonuc = b1 + b2 + b3 + b4 + b5;
            label24.Text = sonuc.ToString();
            yemek.Add("Adana Kebap");
        }
        private void button2_Click(object sender, EventArgs e)
        {
            a2++;
            b2 += 25;
            label13.Text = a2.ToString();
            label18.Text = b2.ToString();
            sonuc = b1 + b2 + b3 + b4 + b5;
            label24.Text = sonuc.ToString();
            yemek.Add("Urfa Kebap");
        }
        private void button3_Click(object sender, EventArgs e)
        {
            a3++;
            b3 += 30;
            label14.Text = a3.ToString();
            label19.Text = b3.ToString();
            sonuc = b1 + b2 + b3 + b4 + b5;
            label24.Text = sonuc.ToString();
            yemek.Add("Kuzu Şiş");
        }
        private void button4_Click(object sender, EventArgs e)
        {
            a4++;
            b4 += 20;
            label15.Text = a4.ToString();
            label20.Text = b4.ToString();
            sonuc = b1 + b2 + b3 + b4 + b5;
            label24.Text = sonuc.ToString();
            yemek.Add("Lüfer");
        }
        private void button5_Click(object sender, EventArgs e)
        {
            a5++;
            b5 += 30;
            label16.Text = a5.ToString();
            label21.Text = b5.ToString();
            sonuc = b1 + b2 + b3 + b4 + b5;
            label24.Text = sonuc.ToString();
            yemek.Add("Tavuk Kanat");
        }
    }
}
