



/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:   ÖDEV 1 
**				ÖĞRENCİ ADI............:   ÖZHAN NURİ YILDIRIM
**				ÖĞRENCİ NUMARASI.......:   B161210109 
**              DERSİN ALINDIĞI GRUP...:   2/C
****************************************************************************/





using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;

namespace WindowsFormsApp7
{
    public partial class Form1 : Form
    {
        kisi bilgi = new kisi();


        public Form1()
        {
       
            InitializeComponent();
        }



        private void btnbilgi_Click(object sender, EventArgs e)
        {

            var personel = File.ReadLines(@"C:\deneme.txt");      //BİLGİLERİ GÖSTER BUTONUNA TIKLAYINCA EKRANA TXT DOSYASINDAKİ TÜM VERİLERİ DÖKER

            foreach (var yaz in personel)
            {
                kisibox.Items.Add(yaz);
            }

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {


        }

        private void btnhesap_Click(object sender, EventArgs e)
        {
            var personel = File.ReadLines(@"C:\deneme.txt");
            
            bilgi.tc = Convert.ToDouble(txttc.Text);



            foreach (var oku in personel)
            {


                string[] okuma = oku.Split(' ');



                if (txttc.Text == okuma[0])                    // eğer tc txt deki gibi doğru girildiyse textbox2 ye okuma değerini yazıyor şimdilik.
                {



                    bilgi.ad = Convert.ToString(okuma[1]);
                    bilgi.soyad = Convert.ToString(okuma[2]);
                    bilgi.yas = Convert.ToDouble(okuma[3]);
                    bilgi.calismaSuresi = Convert.ToDouble(okuma[4]);
                    bilgi.evlilikDurumu = Convert.ToString(okuma[5]);                                      //kisi adında oluşturduğum class'tan verileri çektim.
                    bilgi.esCalisma = Convert.ToString(okuma[6]);
                    bilgi.cocukSayisi = Convert.ToDouble(okuma[7]);
                    bilgi.tabanMaas = Convert.ToDouble(okuma[8]);
                    bilgi.makamTazminat = Convert.ToDouble(okuma[9]);
                    bilgi.idariGorev = Convert.ToDouble(okuma[10]);
                    bilgi.fazlaMesai = Convert.ToDouble(okuma[11]);
                    bilgi.fazlaMesaiUcreti = Convert.ToDouble(okuma[12]);
                    bilgi.vergiMatrahi = Convert.ToDouble(okuma[13]);
                    bilgi.resimYolu = Convert.ToString(okuma[14]);

                    double burutMaas = 0;




                    if (bilgi.evlilikDurumu == "B") // bekarlık durumunda bürüt maaş hesaplaması.
                    {

                        burutMaas = bilgi.tabanMaas + bilgi.makamTazminat + bilgi.idariGorev + bilgi.cocukSayisi * 30 + bilgi.fazlaMesai * bilgi.fazlaMesaiUcreti;
                        burutmaastxt.Text = "burut maas=" + burutMaas;

                        bilgi.damgaVergisi = burutMaas * 10 / 100;
                        damgatxt.Text = "damga vergisi=" + bilgi.damgaVergisi;



                        if (bilgi.vergiMatrahi < 10000)
                        {
                            bilgi.gelirVergisi = burutMaas * 15 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;

                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }

                        if (bilgi.vergiMatrahi >= 10000 && bilgi.vergiMatrahi < 20000)
                        {
                            bilgi.gelirVergisi = burutMaas * 20 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;

                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }
                        if (bilgi.vergiMatrahi >= 20000 && bilgi.vergiMatrahi < 30000)
                        {

                            bilgi.gelirVergisi = burutMaas * 25 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;

                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }
                        if (bilgi.vergiMatrahi >= 30000)
                        {
                            bilgi.gelirVergisi = burutMaas * 30 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;

                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }


                    }
                    if (bilgi.evlilikDurumu == "E" && bilgi.esCalisma == "E")  //evli ve eşi çalışıyor ise bürüt maas.
                    {
                        burutMaas = bilgi.tabanMaas + bilgi.makamTazminat + bilgi.idariGorev + (bilgi.cocukSayisi * 30) + (bilgi.fazlaMesai * bilgi.fazlaMesaiUcreti);
                        burutmaastxt.Text = "burut maas=" + burutMaas;

                        bilgi.damgaVergisi = burutMaas * 10 / 100;
                        damgatxt.Text = "damga vergisi=" + bilgi.damgaVergisi;

                        if (bilgi.vergiMatrahi < 10000)
                        {
                            bilgi.gelirVergisi = burutMaas * 15 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;


                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }

                        if (bilgi.vergiMatrahi >= 10000 && bilgi.vergiMatrahi < 20000)
                        {
                            bilgi.gelirVergisi = burutMaas * 20 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;


                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }
                        if (bilgi.vergiMatrahi >= 20000 && bilgi.vergiMatrahi < 30000)
                        {
                            bilgi.gelirVergisi = burutMaas * 25 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;


                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }
                        if (bilgi.vergiMatrahi >= 30000)
                        {
                            bilgi.gelirVergisi = burutMaas * 30 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;


                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }


                    }

                    if (bilgi.evlilikDurumu == "E" && bilgi.esCalisma == "H")     //evli ve eşi çalışmıyor ise bürüt maas.
                    {
                        burutMaas = bilgi.tabanMaas + bilgi.makamTazminat + bilgi.idariGorev + 200 + (bilgi.cocukSayisi * 30) + (bilgi.fazlaMesai * bilgi.fazlaMesaiUcreti);

                        burutmaastxt.Text = "burut maas=" + burutMaas;


                        bilgi.damgaVergisi = burutMaas * 10 / 100;
                        damgatxt.Text = "damga vergisi=" + bilgi.damgaVergisi;




                        if (bilgi.vergiMatrahi < 10000)
                        {
                            bilgi.gelirVergisi = burutMaas * 15 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;


                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }

                        if (bilgi.vergiMatrahi >= 10000 && bilgi.vergiMatrahi < 20000)
                        {
                            bilgi.gelirVergisi = burutMaas * 20 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;


                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }
                        if (bilgi.vergiMatrahi >= 20000 && bilgi.vergiMatrahi < 30000)
                        {
                            bilgi.gelirVergisi = burutMaas * 25 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;


                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }
                        if (bilgi.vergiMatrahi >= 30000)
                        {
                            bilgi.gelirVergisi = burutMaas * 30 / 100;
                            gelirbox.Text = "gelir vergisi=" + bilgi.gelirVergisi;

                            bilgi.emekliKesintisi = burutMaas * 15 / 100;
                            emeklibox.Text = "emekli kesintisi=" + bilgi.emekliKesintisi;


                            bilgi.netMaas = burutMaas - (bilgi.emekliKesintisi + bilgi.gelirVergisi + bilgi.damgaVergisi);
                            netmaasbox.Text = "net maas = " + bilgi.netMaas;
                        }


                    }

                }

                
             }


        }

        private void btncikis_Click(object sender, EventArgs e)
        {
            MessageBox.Show("         İYİ GÜNLER   ", "ÇIKIŞ");
            this.Close();
          
        }

        private void Form1_Load(object sender, EventArgs e)
        {
          
        }
    }
}



