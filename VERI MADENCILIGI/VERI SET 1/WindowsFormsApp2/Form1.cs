using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MessageBox.Show("OKUL , YAŞ , SAĞLIK , CİNSİYET , CALISMA ZAMANI VE BOS ZAMANI GİREREK DERS ORTALAMASINI BULAN VERİ SETİ" , "VERİ MADENCİLİĞİ ÖDEV" +
                "");
       
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void sonuc_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {

            double yas = Convert.ToInt64(textBox1.Text);
            string cinsiyet = Convert.ToString(textBox2.Text);
            double saglik = Convert.ToInt64(textBox3.Text);
            string okul = Convert.ToString(textBox4.Text);
            double calisma = Convert.ToInt64(textBox5.Text);
            double bos = Convert.ToInt64(textBox6.Text);
            string ortalama;

            

            if (okul == "GP")
            {

                if (yas < 16.5)
                {
                    if (cinsiyet == "E")
                    {
                        if (bos < 4.5)
                        {
                            if (saglik < 3.5)
                            {
                                if (calisma > 3)
                                {
                                    ortalama = "NOT ORTALAMASI : 13.00 ";
                                    sonuc.Text = Convert.ToString(ortalama);
                                }
                                else if (calisma < 3)
                                {
                                    ortalama = "NOT ORTALAMASI : 11.50 ";
                                    sonuc.Text = Convert.ToString(ortalama);
                                }
                            }
                            if (saglik > 3.5 && yas > 15.5)
                            {
                                ortalama = "NOT ORTALAMASI : 12.50 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            if (saglik < 3.5 && calisma < 2.5)
                            {
                                ortalama = "NOT ORTALAMASI : 12.50 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }

                    }

                    if (cinsiyet == "K")
                    {
                        if (saglik > 1.5 && calisma > 3.5)
                        {
                            ortalama = "NOT ORTALAMASI : 11.67 ";
                            sonuc.Text = Convert.ToString(ortalama);
                        }
                        if (saglik < 1.5 && calisma < 3.5 && bos > 1.5)
                        {
                            ortalama = "NOT ORTALAMASI : 7.67 ";
                            sonuc.Text = Convert.ToString(ortalama);
                        }
                    }

                }

                if (yas > 16.5)
                {
                    if (calisma > 1.5)
                    {

                        if (cinsiyet == "E")
                        {
                            if (saglik > 2.5)
                            {
                                ortalama = "NOT ORTALAMASI : 9.111 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            if (saglik < 2.5 && bos > 4.5)
                            {
                                ortalama = "NOT ORTALAMASI : 6.667 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            if (saglik < 2.5 && bos < 4.5)
                            {
                                ortalama = "NOT ORTALAMASI : 11.500 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }
                        if (cinsiyet == "K")
                        {
                            if (saglik > 4.5)
                            {
                                ortalama = "NOT ORTALAMASI : 12.16 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            if (saglik < 4.5 && yas > 18.5)
                            {
                                ortalama = "NOT ORTALAMASI : 13.00 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            else if (saglik < 4.5 && yas < 18.5)
                            {
                                ortalama = "NOT ORTALAMASI : 9.00 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }
                    }

                    if (calisma < 1.5)
                    {
                        if (cinsiyet == "E")
                        {
                            if (saglik > 2.5)
                            {
                                ortalama = "NOT ORTALAMASI : 4.00 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }
                        if (cinsiyet == "K")
                        {
                            if (saglik > 2.5)
                            {
                                ortalama = "NOT ORTALAMASI : 12.50 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }
                    }
                }
            }
            if (okul == "MS")
            {
                if (yas < 16.5)
                {
                    if (cinsiyet == "E")
                    {
                        if (bos < 4.5)
                        {
                            if (saglik < 3.5)
                            {
                                if (calisma > 3)
                                {
                                    ortalama = "NOT ORTALAMASI : 13.00 ";
                                    sonuc.Text = Convert.ToString(ortalama);
                                }
                                else if (calisma < 3)
                                {
                                    ortalama = "NOT ORTALAMASI : 11.50 ";
                                    sonuc.Text = Convert.ToString(ortalama);
                                }
                            }
                            if (saglik > 3.5 && yas > 15.5)
                            {
                                ortalama = "NOT ORTALAMASI : 12.50 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            if (saglik < 3.5 && calisma < 2.5)
                            {
                                ortalama = "NOT ORTALAMASI : 12.50 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }

                    }

                    if (cinsiyet == "K")
                    {
                        if (saglik > 1.5 || calisma > 3.5)
                        {
                            ortalama = "NOT ORTALAMASI : 11.67 ";
                            sonuc.Text = Convert.ToString(ortalama);
                        }
                        if (saglik < 1.5 || calisma < 3.5 || bos > 1.5)
                        {
                            ortalama = "NOT ORTALAMASI : 7.67 ";
                            sonuc.Text = Convert.ToString(ortalama);
                        }
                    }

                }

                if (yas > 16.5)
                {
                    if (calisma > 1.5)
                    {

                        if (cinsiyet == "E")
                        {
                            if (saglik > 2.5)
                            {
                                ortalama = "NOT ORTALAMASI : 9.111 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            if (saglik < 2.5 && bos > 4.5)
                            {
                                ortalama = "NOT ORTALAMASI : 6.667 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            if (saglik < 2.5 && bos < 4.5)
                            {
                                ortalama = "NOT ORTALAMASI : 11.500 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }
                        if (cinsiyet == "K")
                        {
                            if (saglik > 4.5 && bos < 3)
                            {
                                ortalama = "NOT ORTALAMASI : 15.16 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            if (saglik < 4.5 && yas > 18.5)
                            {
                                ortalama = "NOT ORTALAMASI : 13.00 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                            else if (saglik < 4.5 && yas < 18.5)
                            {
                                ortalama = "NOT ORTALAMASI : 9.00 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }
                    }

                    if (calisma < 1.5)
                    {
                        if (cinsiyet == "E")
                        {
                            if (saglik > 2.5)
                            {
                                ortalama = "NOT ORTALAMASI : 4.00 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }
                        if (cinsiyet == "K")
                        {
                            if (saglik > 2.5)
                            {
                                ortalama = "NOT ORTALAMASI : 12.50 ";
                                sonuc.Text = Convert.ToString(ortalama);
                            }
                        }
                    }
                }
            }

        }
    }
}


