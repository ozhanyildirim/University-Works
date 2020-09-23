/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *  Program, kullanicinin istedigi sayi kadar ki�i �retip bu ki�ileri bir text dosyas�nda sakl�yor ve bu ki�ilerin �zelliklerinin do�rulu�unu kontrol ediyor.
 * </p>
 */
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#include <stdbool.h>
#include "RastgeleKisi.h"
#include "Kisi.h"
#include "ImeiNo.h"
#include "KimlikNo.h"


int main()
  {
    RastgeleKisi r = RastgeleKisiOlustur();
    KimlikNo kimlik = KimlikOlsustur();
    ImeiNo imei = imeiOlustur();

    int secim = 0;
    int kisiSayisi = 0;
    while (true)
    {
      printf("%s","1-Rastgele Kisi Uret\n2-Uretilmis Dosya Kontrol Et\n3-Cikis\n");
      scanf("%d",secim );
      switch (secim)
      {
        case 1:
          printf("%s","Kaç kişi üretmek istiyorsunuz?");
          scanf("%d",kisiSayisi);
          for (int i = 0; i < kisiSayisi; i++)
          {
              r->RastgeleKisiUrett(r);
          }
               printf("%s","Üretilen kişiler dosyaya yazdırıldı\n");
               break;

          case 2:
              printf("%s\n","TC KONTROL");
              printf("%s",kimlik->TcDogrulamaa());
              printf("%s\n"," Gecerli");

              printf("%s\n","IMEI KONTROL");
              printf("%s",imei->ImeiNoDogrulaa());
              printf("%s\n"," Gecerli");
              break;

          case 3:
              return 0;
          default:
              printf("%s\n", "Boyle bir secenek yok ." );
              break;
      }
    }
  }
