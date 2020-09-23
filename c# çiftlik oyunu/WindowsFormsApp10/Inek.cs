using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace WindowsFormsApp10
{
    class Inek : Ciftlik , ICiftlik 
    {
        public Inek()
        {
            UrunVer = 8;   // 8 saniyede bir ürün vermesi için
            UrunSayisi = 0;

            Can = 100;      // progressbar=100
            Kasa = 0;            //kasa değeri 0
            Fiyat = 5;               //          5 TL DEN SATILACAK

            HayvanSesi = Application.StartupPath + "\\inek.wav";        // hayvanların ses dosyası
        }

        public void canAzalt()
        {
            Can = Can - 8;     // 5 saniyede bir canı azalıyor
        }


        public void yemVer()
        {
            Can = 100;                              //yem ver dediğinde progressbarı fullemesi
        }


    



        public void urunArttır()
        {
            UrunSayisi = UrunSayisi + 1;
        }

        public void urunSat()           // ürün sayısını arttır 
        {
            if (UrunSayisi == 0)     //ürün sayısı 0 olursa işlem yapma
            {
                return;                                             // ürün sat dediğinde azaltması
            }

            Kasa = Kasa + UrunSayisi * Fiyat;       // kasa hesaplaması

            UrunSayisi = 0;
        }

    


        public void UrunSat()
        {
            throw new NotImplementedException();            // arabirimi uygula dedim yoksa interface çalışmıyor?
        }

        public void YemVer()
        {
            throw new NotImplementedException();
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

