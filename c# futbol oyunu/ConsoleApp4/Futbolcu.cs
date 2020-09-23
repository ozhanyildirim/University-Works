using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp4
{
    public class Futbolcu
    {


        public string AdSoyad { get; set; }
        public int FormaNo { get; set; }
        public double Hiz { get; set; }
        public double Dayaniklilik { get; set; }               // isim tanımlamaları 
        public double Pas { get; set; }
        public double Sut { get; set; }
        public double Yetenek { get; set; }
        public double Kararlilik { get; set; }
        public double DogalForm { get; set; }
        public double PasSkor { get; set; }
        public double Sans { get; set; }
        public double GolSkor { get; set; }


        public virtual bool PasVer()
        {


            PasSkor =   Pas * 0.3 + Yetenek * 0.3 + Dayaniklilik * 0.1 + DogalForm * 0.1 + Sans * 0.2;
            Defans def = new Defans();
            PasSkor = def.Pas * 0.3 + def.Yetenek * 0.3 + def.Dayaniklilik * 0.3 + def.DogalForm * 0.3 + def.PozisyonAlma * 0.1 + def.Sans * 0.2;                                      // PASVER METODU 
            OrtaSaha os = new OrtaSaha();                           
            PasSkor = (os.Pas * 0.3 + os.Yetenek * 0.2 + os.OzelYetenekOrtaSaha * 0.2 + os.Dayaniklilik * 0.1 + os.DogalForm * 0.1 + os.UzunTop * 0.1 + os.TopSurme * 0.1 + os.Sans * 0.1) + 30;
            Forvet fwd = new Forvet();
            PasSkor = fwd.Pas * 0.3 + fwd.Yetenek * 0.2 + fwd.OzelYetenekForvet * 0.2 + fwd.Dayaniklilik * 0.1 + fwd.DogalForm * 0.1 + fwd.Sans * 0.1;


            if (Convert.ToInt32(PasSkor) > 60)
            {
                return true;
            }
            else
                return false;

        }

        public virtual bool GolVurusu()
        {
            
            GolSkor = (Yetenek * 0.3 + Sut * 0.2 +Kararlilik * 0.1 + DogalForm * 0.1 + Hiz * 0.1 + Sans * 0.2);
            Defans def = new Defans();
            GolSkor =( def.Yetenek * 0.3 + def.Sut * 0.2 + def.Kararlilik * 0.1 + def.DogalForm * 0.1 + def.KafaDefans * 0.1 + def.Sicrama * 0.1 + def.Sans * 0.1);                                             //GOL VURUŞU METODU
            OrtaSaha os = new OrtaSaha(); 
            GolSkor = (os.Yetenek * 0.3 + os.OzelYetenekOrtaSaha * 0.2 + os.Sut * 0.2 + os.IlkDokunusOrtaSaha * 0.1 + os.Kararlilik * 0.1 + os.DogalForm * 0.1 + os.Sans * 0.1 ) ;
            Forvet fwd = new Forvet();
            GolSkor =( fwd.Yetenek * 0.2 + fwd.OzelYetenekForvet * 0.2 + fwd.Sut * 0.1 + fwd.KafaForvet * 0.1 + fwd.IlkDokunusForvet * 0.1 + fwd.Bitiricilik * 0.1 + fwd.SogukKanlilik * 0.1 + fwd.Kararlilik * 0.1 + fwd.DogalForm * 0.1 + fwd.Sans * 0.1 );

            if (Convert.ToInt32(GolSkor) > 70)
            {
                return true;
            }
            else
            {
                return false;
            }


        }

        public Futbolcu()
        {
            

        }


        public Futbolcu(string AdSoyad, int FormaNo)
        {
            
    }


    }
   


   public class Defans : Futbolcu
    {
        public double PozisyonAlma { get; set; }                    // FUTBOLCUDAN TÜRETİLEN DEFANS SINIFI
        public double KafaDefans  { get; set; }
        public double Sicrama  { get; set; }
        public string AdSoyadef;



       
    }

    public class OrtaSaha : Futbolcu
    {
       
        public double UzunTop { get; set; }
        public double IlkDokunusOrtaSaha { get; set; }              // FUTBOLCUDAN TÜRETİLEN ORTASAHA SINIFI
        public double Uretkenlik { get; set; }
        public double TopSurme { get; set; } 
        public double OzelYetenekOrtaSaha{ get; set; }



  



    }

    public class Forvet : Futbolcu
    {

        public double Bitiricilik { get; set; }
        public double IlkDokunusForvet { get; set; }
        public double KafaForvet { get; set; }                              // FUTBOLCUDAN TÜRETİLEN FORVET SINIFI
        public double OzelYetenekForvet { get; set; }
        public double SogukKanlilik { get; set; }
    }












}

