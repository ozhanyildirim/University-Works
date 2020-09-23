
/****************************************************************************
**					   SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				   BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				 NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........: PROJE ÖDEVİ
**				ÖĞRENCİ ADI............: ÖZHAN NURİ YILDIRIM
**				ÖĞRENCİ NUMARASI.......: B161210109
**              DERSİN ALINDIĞI GRUP...: 2C
****************************************************************************/


















using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;
using System.Windows.Forms;
using System.Media;
using System.Timers;
using Timer = System.Timers.Timer;

namespace WindowsFormsApp10
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            timer1.Start();                         // PROGRAM ÇALIŞINCA OTOMATİK OLARAK SÜRE İŞLEMEYE BAŞLIYOR 
        }


        Tavuk tvk = new Tavuk();
        Ordek ord = new Ordek();
        Inek inek = new Inek();                     // classları burda tanımladım
        Keci keci = new Keci();


        SoundPlayer ses = new SoundPlayer();         // sesin çalması için gerekli tanımlama

        int sayi=0;
        int i = 0;
        int j = 0;



        private void timer1_Tick(object sender, EventArgs e)

        {


            sayi++;

            timerlbl.Text = sayi.ToString() + " SN";


            /////////////////////////////////////////       TAVUK          ///////////////////////////////////////////////




            if (tvk.Can > 0)
            {

                if (sayi % tvk.UrunVer == 0)                // ürün vermesi için
                {
                    tvk.urunArttır();
                }


                tvk.canAzalt();

                if (tvk.Can <= 0)
                {
                    tavukbar.Value = 0;
                    tavuklbl.Text = "ÖLDÜ";

                    tavukyembtn.Enabled = false;     //yem ver butonu çalışmıcak

                    ses.SoundLocation = tvk.HayvanSesi;         // ölünce ses çıkarması
                    ses.Play();
                }


                else
                {
                    tavukbar.Value = tvk.Can;                                                   // eğer şartlar sağlanmazsa ürün sayısını arttır
                    TavukDepolbl.Text = tvk.UrunSayisi.ToString() + " ADET";

                }
            }

            ////////////////////////////////          ÖRDEK          ///////////////////////////////////////





            if (ord.Can > 0)
            {

                if (sayi % ord.UrunVer == 0)                // ürün vermesi için
                {
                    ord.urunArttır();
                }


                ord.canAzalt();

                if (ord.Can <= 0)
                {
                    ordekbar.Value = 0;
                    ordeklbl.Text = "ÖLDÜ";
                    ordekyembtn.Enabled = false;                 //yem ver butonu çalışmıcak
                    ses.SoundLocation = ord.HayvanSesi;         // ölünce ses çıkarması
                    ses.Play();
                }
                else
                {
                    ordekbar.Value = ord.Can;
                    OrdekDepolbl.Text = ord.UrunSayisi.ToString() + " ADET";
                }
            }

            ///////////////////////////////////////////////          İNEK         ///////////////////////////////////////


            if (inek.Can > 0)
            {

                if (sayi % inek.UrunVer == 0)                // ürün vermesi için
                {
                    inek.urunArttır();
                }


                inek.canAzalt();

                if (inek.Can <= 0)
                {
                    inekbar.Value = 0;

                    ineklbl.Text = "ÖLDÜ";

                    inekyembtn.Enabled = false;              //yem ver butonu çalışmıcak

                    ses.SoundLocation = inek.HayvanSesi;         // ölünce ses çıkarması
                    ses.Play();
                }
                else
                {
                    inekbar.Value = inek.Can;
                    InekDepolbl.Text = inek.UrunSayisi.ToString() + " ADET";
                }
            }


            /////////////////////////////////////////          KEÇİ          ///////////////////////////////////////

            if (keci.Can > 0)
            {

                if (sayi % keci.UrunVer == 0)                // ürün vermesi için
                {
                    keci.urunArttır();
                }


                keci.canAzalt();

                if (keci.Can <= 0)
                {
                    kecibar.Value = 0;
                    kecilbl.Text = "ÖLDÜ";
                    keciyembtn.Enabled = false;              //yem ver butonu çalışmıcak
                    ses.SoundLocation = keci.HayvanSesi;         // ölünce ses çıkarması
                    ses.Play();
                }
                else
                {
                    kecibar.Value = keci.Can;
                    KeciDepolbl.Text = keci.UrunSayisi.ToString() + " ADET";
                }
            }

        }




      
        
        
        //////////////////////////////////////////////        ÜRÜN SATIŞLARI   //////////////////////////////////////////////////






        private void TavukYumurtaSatbtn_Click(object sender, EventArgs e)


        {
            tvk.urunSat();                                                               // ÜRÜN SATMA

            TavukDepolbl.Text = tvk.UrunSayisi.ToString() + " ADET";

            int Toplam = tvk.Kasa + inek.Kasa + keci.Kasa + ord.Kasa;

            Kasalbl.Text = Toplam.ToString() + " TL";

        }

        private void OrdekYumurtaSatBtn_Click(object sender, EventArgs e)


        {

            ord.urunSat();                                                                       // ÜRÜN SATMA

            OrdekDepolbl.Text = ord.UrunSayisi.ToString() + " ADET";

            int Toplam = tvk.Kasa + inek.Kasa + keci.Kasa + ord.Kasa;

            Kasalbl.Text = Toplam.ToString() + " TL";


        }

        private void InekSutSatBtn_Click(object sender, EventArgs e)
        {
            inek.urunSat();                                                                     // ÜRÜN SATMA

            InekDepolbl.Text = inek.UrunSayisi.ToString() + " ADET";

            int Toplam = tvk.Kasa + inek.Kasa + keci.Kasa + ord.Kasa;

            Kasalbl.Text = Toplam.ToString() + " TL";

        }

        private void KecıSutSatBtn_Click(object sender, EventArgs e)
        {
            keci.urunSat();                                                                                  // ÜRÜN SATMA

            KeciDepolbl.Text = keci.UrunSayisi.ToString() + " ADET";

            int Toplam = tvk.Kasa + inek.Kasa + keci.Kasa + ord.Kasa;

            Kasalbl.Text = Toplam.ToString() + " TL";

        }

     

        



//////////////////////////////////////////////     YEM VERME   /////////////////////////////////////////////////////////////////////////////

        private void tavukyembtn_Click(object sender, EventArgs e)
        {               
            tvk.yemVer();                                                           //YEM VER KOMUTU TIKLANINCA PROGRESSBAR DEĞERİ 100 OLUYOR

            tavukbar.Value = tvk.Can;                               
        }

        private void timer2_Tick(object sender, EventArgs e)
        {
            
        }

        private void ordekyembtn_Click(object sender, EventArgs e)
        {
            ord.yemVer();                                                    //YEM VER KOMUTU TIKLANINCA PROGRESSBAR DEĞERİ 100 OLUYOR

            ordekbar.Value = ord.Can;
        }

        private void inekyembtn_Click(object sender, EventArgs e)
        {
            inek.yemVer();                                                                           //YEM VER KOMUTU TIKLANINCA PROGRESSBAR DEĞERİ 100 OLUYOR

            inekbar.Value = inek.Can;
        }

        private void keciyembtn_Click(object sender, EventArgs e)
        {   
            keci.yemVer();                                                               //YEM VER KOMUTU TIKLANINCA PROGRESSBAR DEĞERİ 100 OLUYOR

            kecibar.Value = keci.Can;
        }

        private void tavukbar_Click(object sender, EventArgs e)
        {

        }

        
    }
}
