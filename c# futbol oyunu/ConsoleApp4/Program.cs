

/****************************************************************************
**					SAKARYA ÜNİVERSİTESİ
**				BİLGİSAYAR VE BİLİŞİM BİLİMLERİ FAKÜLTESİ
**				    BİLGİSAYAR MÜHENDİSLİĞİ BÖLÜMÜ
**				   NESNEYE DAYALI PROGRAMLAMA DERSİ
**					2018-2019 BAHAR DÖNEMİ
**	
**				ÖDEV NUMARASI..........:  2. ÖDEV
**				ÖĞRENCİ ADI............:  ÖZHAN NURİ YILDIRIM
**				ÖĞRENCİ NUMARASI.......:  B161210109
**              DERSİN ALINDIĞI GRUP...:  2C
****************************************************************************/





using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    class Program
    {



        public static void Main(string[] args)
        {


            var takim = new List<Futbolcu>
            {

            new Defans()  {AdSoyad = "VIRGIL VAN DIJK" , FormaNo=1},
             new Defans() {AdSoyad = "DEJAN LOVREN" , FormaNo=2},
             new Defans() {AdSoyad = "TRENT ALEXANDER ARNOLD" , FormaNo=3},
             new Defans() {AdSoyad = "ANDREW ROBERTSON" , FormaNo=4},                               // LİSTE ŞEKLİNDE İLK 11 İN TANIMLAMALARI 
              new OrtaSaha() {AdSoyad = "XHERDAN SHAQIRI" , FormaNo=5},
             new OrtaSaha() {AdSoyad = "JAMES MILNER" , FormaNo=6},
             new OrtaSaha() {AdSoyad = "MOHAMMED SALAH" , FormaNo=7},
            new OrtaSaha() {AdSoyad = "ADAM LALLANA" , FormaNo=8},
           new OrtaSaha() {AdSoyad = "ROBERTO FIRMINO" , FormaNo=9},
             new Forvet() {AdSoyad = "SADIO MANE" , FormaNo=10},
              new Forvet() {AdSoyad = "DANIEL STURRIDGE" , FormaNo=11},
            };


            Random rnd = new Random();                       // RASTGELE SKİLLER İÇİN RANDOM KOMUTU TANIMI




            Futbolcu ftb = new Futbolcu();

            {

                ftb.FormaNo = rnd.Next(1, 11);
                ftb.Dayaniklilik = rnd.Next(50, 100);
                ftb.DogalForm = rnd.Next(50, 100);
                ftb.Hiz = rnd.Next(50, 100);
                ftb.Kararlilik = rnd.Next(50, 100);
                ftb.Pas = rnd.Next(50, 100);                                // futbolcu için random skill tanımlamaları
                ftb.Sans = rnd.Next(50, 100);
                ftb.Sut = rnd.Next(50, 100);
                ftb.Yetenek = rnd.Next(50, 100);
                ftb.PasSkor = ftb.Pas * 0.3 + ftb.Yetenek * 0.3 + ftb.Dayaniklilik * 0.1 + ftb.DogalForm * 0.1 + ftb.Sans * 0.2;
                ftb.GolSkor = (ftb.Yetenek * 0.3 + ftb.Sut * 0.2 + ftb.Kararlilik * 0.1 + ftb.DogalForm * 0.1 + ftb.Hiz * 0.1 + ftb.Sans * 0.2);
            }


            Defans def = new Defans();
            {

                def.Dayaniklilik = rnd.Next(50, 100);
                def.DogalForm = rnd.Next(50, 100);
                def.Hiz = rnd.Next(50, 100);
                def.Kararlilik = rnd.Next(50, 100);                      // defans oyuncuları için random skill tanımlamaları
                def.Pas = rnd.Next(50, 100);
                def.Sans = rnd.Next(50, 100);
                def.Sut = rnd.Next(50, 100);
                def.Yetenek = rnd.Next(50, 100);
                def.PozisyonAlma = rnd.Next(50, 90);
                def.KafaDefans = rnd.Next(50, 90);
                def.Sicrama = rnd.Next(50, 90);
                def.PasSkor = def.Pas * 0.3 + def.Yetenek * 0.3 + def.Dayaniklilik * 0.3 + def.DogalForm * 0.3 + def.PozisyonAlma * 0.1 + def.Sans * 0.2;
                def.GolSkor = (def.Yetenek * 0.3 + def.Sut * 0.2 + def.Kararlilik * 0.1 + def.DogalForm * 0.1 + def.KafaDefans * 0.1 + def.Sicrama * 0.1 + def.Sans * 0.1);

            }





            OrtaSaha os = new OrtaSaha();

            {

                os.Dayaniklilik = rnd.Next(50, 100);
                os.DogalForm = rnd.Next(50, 100);
                os.Hiz = rnd.Next(50, 100);
                os.Kararlilik = rnd.Next(50, 100);
                os.Pas = rnd.Next(50, 100);
                os.Sans = rnd.Next(50, 100);                                     // ortasaha oyuncuları için random skill tanımlamaları
                os.Sut = rnd.Next(50, 100);
                os.Yetenek = rnd.Next(50, 100);
                os.IlkDokunusOrtaSaha = rnd.Next(60, 100);
                os.OzelYetenekOrtaSaha = rnd.Next(60, 100);
                os.TopSurme = rnd.Next(60, 100);
                os.Uretkenlik = rnd.Next(60, 100);
                os.UzunTop = rnd.Next(60, 100);
                os.PasSkor = (os.Pas * 0.3 + os.Yetenek * 0.2 + os.OzelYetenekOrtaSaha * 0.2 + os.Dayaniklilik * 0.1 + os.DogalForm * 0.1 + os.UzunTop * 0.1 + os.TopSurme * 0.1 + os.Sans * 0.1);
                os.GolSkor = (os.Yetenek * 0.3 + os.OzelYetenekOrtaSaha * 0.2 + os.Sut * 0.2 + os.IlkDokunusOrtaSaha * 0.1 + os.Kararlilik * 0.1 + os.DogalForm * 0.1 + os.Sans * 0.1);

            }




            Forvet fwd = new Forvet();
            {

                fwd.Dayaniklilik = rnd.Next(50, 100);
                fwd.DogalForm = rnd.Next(50, 100);
                fwd.Hiz = rnd.Next(50, 100);
                fwd.Kararlilik = rnd.Next(50, 100);
                fwd.Pas = rnd.Next(50, 100);
                fwd.Sans = rnd.Next(50, 100);                                        // forvet oyuncuları için random skill tanımlamaları
                fwd.Sut = rnd.Next(50, 100);
                fwd.Yetenek = rnd.Next(50, 100);
                fwd.Bitiricilik = rnd.Next(70, 100);
                fwd.IlkDokunusForvet = rnd.Next(70, 100);
                fwd.KafaForvet = rnd.Next(70, 100);
                fwd.SogukKanlilik = rnd.Next(70, 100);
                fwd.OzelYetenekForvet = rnd.Next(70, 100);
                fwd.PasSkor = fwd.Pas * 0.3 + fwd.Yetenek * 0.2 + fwd.OzelYetenekForvet * 0.2 + fwd.Dayaniklilik * 0.1 + fwd.DogalForm * 0.1 + fwd.Sans * 0.1;
                fwd.GolSkor = (fwd.Yetenek * 0.2 + fwd.OzelYetenekForvet * 0.2 + fwd.Sut * 0.1 + fwd.KafaForvet * 0.1 + fwd.IlkDokunusForvet * 0.1 + fwd.Bitiricilik * 0.1 + fwd.SogukKanlilik * 0.1 + fwd.Kararlilik * 0.1 + fwd.DogalForm * 0.1 + fwd.Sans * 0.1);
            }



            int TopKimde = rnd.Next(3, 11);

            //bool Gololabilir = true;
            //bool Pasolabilir = true;
            //int AtilanPas;
            //bool GolTopKimde = true;
            //for (int i = 0; i < 3; i++)
            //{
            //    if (Pasolabilir == true)
            //    {
            //        if (takim[TopKimde - 1].PasVer() == true)

            //            while (true)
            //            {
            //                AtilanPas = TopKimde;
            //                TopKimde = rnd.Next(1, 11);


            //                if (TopKimde != AtilanPas)
            //                {
            //                    Console.WriteLine("***************************************");
            //                    Console.WriteLine("BAŞARILI PAS");
            //                    Console.WriteLine("***************************************");
            //                    break;
            //                }

            //                else
            //                {

            //                    Console.WriteLine("***************************************");
            //                    Console.WriteLine("HATALI PAS");
            //                    Console.WriteLine("***************************************");
            //                    break;
            //                }                                                                                                              

            //            }
            //    }
            //        if (Gololabilir == true)
            //        {                                                             
            //         if(GolTopKimde ==true)
            //            {
            //                if (takim[TopKimde -1 ].GolVurusu() == true)
            //                {
            //                Console.WriteLine("***************************************");
            //                Console.WriteLine("TOP AĞLARDA GOOOOOOLLLLLLLL");
            //                    Console.WriteLine("GOLÜ ATAN FUTBOLCU " + takim[TopKimde - 1].FormaNo + " FORMA NUMARASIYLA " + takim[TopKimde - 1].AdSoyad);
            //                Console.WriteLine("***************************************");
            //                Console.WriteLine("                             ");
            //                break;
            //                }

            //                else
            //                {
            //                Console.WriteLine("---------------------------------------");
            //                Console.WriteLine("MALESEF GOL OLMADI");
            //                Console.WriteLine("---------------------------------------");
            //                Console.WriteLine("                             ");
            //                break;


            //                }

            //            }                                                             

            //        }

            // }





            Console.WriteLine("***************************************");
            Console.WriteLine("HAKEM İLK DÜDÜĞÜ ÇALIYOR VE MAÇ BAŞLADI ");
            Console.WriteLine("***************************************");

            Console.WriteLine("                             ");

            if (ftb.PasSkor > 60)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("PASI İYİ YERE PASI ATAN  : " + takim[TopKimde].AdSoyad);
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("");
                Console.ReadKey();
                return;
            }

            if (os.PasSkor > 60)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine(" 2. PAS GÜZEL GELDİ    :  " + takim[TopKimde -1].AdSoyad);
                Console.WriteLine("---------------------------------------");
            }
            else
            {

                Console.WriteLine("PAS GEÇMİYOR MALESEF HATALI PAS");
                Console.ReadKey();
                return;

            }
            if (fwd.PasSkor > 60)
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("3. PASI ALAN OYUNCU  :  " + takim[TopKimde-2].AdSoyad);
                Console.WriteLine("---------------------------------------");
            }
            else
            {
                Console.WriteLine("PAS GEÇMİYOR MALESEF HATALI PAS");
                Console.ReadKey();
                return;

            }




            if (ftb.GolSkor > 70) ;
       
              else
             {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("MALESEF GOL OLMADI GOLÜ KAÇIRAN OYUNCU    " + takim[TopKimde - 3].FormaNo + " FORMA NUMARASIYLA " + takim[TopKimde - 3].AdSoyad);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("                             ");
                Console.ReadKey();
                return;

              }
                 if (def.GolSkor > 70) ;
            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("MALESEF GOL OLMADI GOLÜ KAÇIRAN OYUNCU    " + takim[TopKimde - 3].FormaNo + " FORMA NUMARASIYLA " + takim[TopKimde - 3].AdSoyad);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("                             ");
                Console.ReadKey();
                return;
            }
            if (os.GolSkor > 70) ;
            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("MALESEF GOL OLMADI GOLÜ KAÇIRAN OYUNCU    " + takim[TopKimde - 3].FormaNo + " FORMA NUMARASIYLA " + takim[TopKimde - 3].AdSoyad);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("                             ");
                Console.ReadKey();
                return;
            }
                if (fwd.GolSkor > 70)

                {
                    Console.WriteLine("                             ");
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("TOP AĞLARDA GOOOOOOLLLLLLLL");
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("GOLÜ ATAN FUTBOLCU " + takim[TopKimde - 3].FormaNo + " FORMA NUMARASIYLA " + takim[TopKimde - 3].AdSoyad);
                    Console.WriteLine("*************************************************************************");
                    Console.WriteLine("                             ");

                }
            else
            {
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("MALESEF GOL OLMADI GOLÜ KAÇIRAN OYUNCU    " + takim[TopKimde - 3].FormaNo + " FORMA NUMARASIYLA " + takim[TopKimde - 3].AdSoyad);
                Console.WriteLine("---------------------------------------");
                Console.WriteLine("                             ");
                Console.ReadKey();
                return;
            }


            Console.WriteLine("                             ");
        
            Console.WriteLine("HAKEM SON DÜDÜĞÜ ÇALDI MAÇ BİTİYOR ...");

            Console.ReadKey();




        }



    }
        }
    

      

