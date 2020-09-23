/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *  Program rastgele imei oluþturuyor
 * </p>
 */
#include "ImeiNo.h"
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#include <stdbool.h>

ImeiNo imeiOlustur()
{
  ImeiNo this;
  this =(ImeiNo)malloc(sizeof(struct IMEINO));
  this->imeiUrett =&imeiUret;
  this->ImeiNoDogrulaa=&ImeiNoDogrula;
  this->ImeiNoYokett=&ImeiNoYoket;
  return this;
}

int *imeiUret()
{
  int imei[15];
  int toplam = 0;
  int rastgele;

  srand(time(NULL));

  for (int i = 0; i < 14; i++)
  {
     imei[i] = 0+rand()%9;
  }

  imei[14] = 0;

  for (int i = 0; i < 14; i++)
  {
      if(i%2 == 0)
      {
          toplam += imei[i];
      }
      else if (i%2 != 0)
      {
          toplam += (imei[i]*2);
      }
  }


  while (toplam%10 != 0)
     {
         imei[14]++;
         toplam++;
     }

      int *p;
      p = imei;
      return p;
}

int ImeiNoDogrula()
{
  int sayac = 0;
  FILE *dosya;
  dosya=fopen("program.txt","r");
  int imei[15];
  char karakter;

  while (!feof(dosya))
  {
    for (int i = 0; i < 150; i++)
    {
      karakter = fgetc(dosya);
      if (karakter == '(')
      {
        for (int i = 0; i < 15; i++)
        {
          imei[i] = fgetc(dosya);
        }
      }
      else if (karakter == ')')
        break;
    }

    for (int i = 0; i < 15; i++)
    {
      imei[i] = imei[i] - '0';
    }

    int toplam = 0;
    int sonRakam = 0;
    int sonEleman = imei[14];

    for (int i = 0; i < 14; i++)
    {
      if(i%2 == 0)
      {
        toplam += imei[i];
      }
      else if (i%2 != 0)
      {
        toplam += (imei[i]*2);
      }
    }

    while(toplam%10 != 0)
    {
      sonRakam++;
      toplam++;
    }

    if (sonRakam == sonEleman)
    {
      sayac++;
    }
  }

  return sayac;

}

void ImeiNoYoket(ImeiNo i)
{
  if (i==NULL)
  return;
  free(i);
  i=NULL;
}
