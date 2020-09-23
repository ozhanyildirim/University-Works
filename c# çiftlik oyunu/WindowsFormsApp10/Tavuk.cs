using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp10 { 

     

    class Tavuk : Ciftlik , ICiftlik
    {
        public Tavuk()
        {


            Can = 100;              // progressbar=100
            UrunVer = 3;             // 3 saniyede bir ürün vermesi için
            UrunSayisi = 0;
           
            Kasa = 0;                //kasa değeri 0
            Fiyat = 1;              //fiyat değeri
            HayvanSesi = Application.StartupPath + "\\tavuk.wav";       // hayvanların ses dosyası
        }


        public void canAzalt()
        {
            Can = Can - 2;     // 2 saniyede bir canı azalıyor
        }

        public void yemVer()
        {
            Can = 100;                              //yem ver dediğinde progressbarı fullemesi
        }

        public void urunSat()
        {
            if (UrunSayisi == 0)
            {
                return;                                             // ürün sat dediğinde azaltması
            }
            Kasa = Kasa + UrunSayisi * Fiyat;
            UrunSayisi = 0;
        }

     

        public void urunArttır()
        {
            UrunSayisi = UrunSayisi + 1;
        }

        

    

        public void UrunSat()
        {
            throw new NotImplementedException();
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

