using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            double yas = Convert.ToInt64(textBox2.Text);
            string cinsiyet = Convert.ToString(textBox1.Text);
            string AnneIs = Convert.ToString(textBox3.Text);
            string BabaIs = Convert.ToString(textBox4.Text);
            double calisma = Convert.ToInt64(textBox5.Text);
            double aile = Convert.ToInt64(textBox6.Text);
            string okul;


            if (yas <= 16.5)
            {
                okul = "Gabriel Pereira Okulu";
                label7.Text = Convert.ToString(okul);
            }

            if (yas > 16.5)
            {
                if (aile > 1.5)
                {
                    okul = "Mousinho da Silveira";
                    label7.Text = Convert.ToString(okul);
                }

                if (aile > 1.5)
                {
                    if (calisma >= 3.5)
                    {
                        okul = "Gabriel Pereira Okulu";
                        label7.Text = Convert.ToString(okul);
                    }
                    if (calisma < 3.5)
                    {
                        if (yas > 17.5 && aile > 2.5 && calisma > 1.5)
                        {
                            if (cinsiyet == "K" && aile > 4.5 && calisma > 2.5)
                            {
                                okul = "Mousinho da Silveira";
                                label7.Text = Convert.ToString(okul);
                            }
                            if (cinsiyet == "E")
                            {
                                okul = "Gabriel Pereira Okulu";
                                label7.Text = Convert.ToString(okul);
                            }

                        }
                        if (yas > 17.5 && aile <= 2.5)
                        {
                            okul = "Gabriel Pereira Okulu";
                            label7.Text = Convert.ToString(okul);
                        }
                        if (yas > 17.5 && calisma <= 1.5 && AnneIs == "Ev Hanımı" || AnneIs == "Diğer")
                        {
                            okul = "Mousinho da Silveira";
                            label7.Text = Convert.ToString(okul);
                        }
                        if (yas > 17.5 && calisma <= 1.5 && AnneIs == "Öğretmen" || AnneIs == "Hizmetçi")
                        {
                            okul = "Gabriel Pereira Okulu";
                            label7.Text = Convert.ToString(okul);
                        }

                        if (yas <= 17.5 && aile > 4.5)
                        {
                            okul = "Gabriel Pereira Okulu";
                            label7.Text = Convert.ToString(okul);
                        }
                        if (yas <= 17.5 && aile <= 4.5 && calisma > 2.5)
                        {
                            okul = "Gabriel Pereira Okulu";
                            label7.Text = Convert.ToString(okul);
                        }
                        if (yas <= 17.5 && aile <= 4.5 && calisma <= 2.5 && BabaIs == "Çalışmıyor" || BabaIs == "Öğretmen" || BabaIs == "Diğer" && aile > 3.5)
                        {
                            okul = "Gabriel Pereira Okulu";
                            label7.Text = Convert.ToString(okul);
                        }
                        if (yas <= 17.5 && aile <= 4.5 && calisma <= 2.5 && BabaIs == "Hizmetçi" && aile <= 3.5)
                        {

                            okul = "Mousinho da Silveira";
                            label7.Text = Convert.ToString(okul);
                        }


                    }

                }








            }
        }
    }
}
