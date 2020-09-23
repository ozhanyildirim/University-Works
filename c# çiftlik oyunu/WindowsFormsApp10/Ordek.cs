using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10
{
    class Ordek : Ciftlik , ICiftlik 
    {
        public Ordek()
        {
            UrunVer = 5;    //  5  saniyede bir ürün vermesi için


            UrunSayisi = 0;     

            Can = 100;             // progressbar=100
            Kasa = 0;            //kasa değeri 0
            Fiyat = 3;           //   3 TL DEN SATILACAK

            HayvanSesi = Application.StartupPath + "\\ordek.wav";   // hayvanların ses dosyası
        }




        public void yemVer()
        {
            Can = 100;                              //yem ver dediğinde progressbarı fullemesi
        }



        public void canAzalt()
        {
            Can = Can - 3;     // 3 saniyede bir canı azalıyor
        }


      



        public void urunArttır()
        {
            UrunSayisi = UrunSayisi + 1;
        }

        public void urunSat()       // ürün sayısını arttır 
        {
            if (UrunSayisi == 0)    //ürün sayısı 0 olursa işlem yapma
            {
                return;                                             // ürün sat dediğinde azaltması
            }

            Kasa = Kasa + UrunSayisi * Fiyat;       // kasa hesaplaması

            UrunSayisi = 0;         //ördek kasasını sıfırlıyor baştan sayması için
        }

     



        public void UrunSat()
        {
            throw new NotImplementedException();
        }

        public void YemVer()
        {
            throw new NotImplementedException();            // arabirimi uygula dedim yoksa interface çalışmıyor?
        }

        public void CanAzalt()
        {
            throw new NotImplementedException();
        }


        void ICiftlik.UrunVer()
        {
            throw new NotImplementedException();
        }
    }
}
