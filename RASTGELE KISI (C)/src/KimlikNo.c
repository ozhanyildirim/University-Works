/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *   Program,rastgele kimlik no üretiyor
 * </p>
 */
#include "KimlikNo.h"
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#include <stdbool.h>



KimlikNo KimlikOlsustur()
{
  KimlikNo this;
  this = (KimlikNo)malloc(sizeof(struct KIMLIKNO));
  this->kimlikUrett=&kimlikUret;
  this->TcDogrulamaa=&TcDogrulama;
  this->KimlikYokett=&KimlikYoket;


  return this;

}

int *kimlikUret()
{
  int tc[11];

  srand(time(NULL));

  tc[0] = 1+rand()%9;

  for (int i = 1; i <= 8; i++)
  {
    tc[i] = 0+rand()%9;
  }

  tc[9] = (7*(tc[0]+tc[2]+tc[4]+tc[6]+tc[8])-(tc[1]+tc[3]+tc[5]+tc[7]) )%10 ;
  tc[10] = ( tc[0]+tc[1]+tc[2]+tc[3]+tc[4]+tc[5]+tc[6]+tc[7]+tc[8]+tc[9] )%10 ;


  int *q;
  q= tc;
  return q;
}

int TcDogrulama()
{
  int sayac = 0;
  FILE *dosya;
  dosya=fopen("program.txt","r");
  int tc[11];
  int toplam=0;
  char karakter;

  while (!feof(dosya))
  {
    for (int i = 0; i < 11; i++)
    {
      karakter = fgetc(dosya);
      tc[i]=karakter;
    }

    for (int j = 0; j <10; j++)
    {
      toplam +=tc[j]-'0';
    }

    if ((toplam % 10) ==tc[10]-'0')
    {
      if ((('0'-tc[0]+'0'-tc[2]+'0'-tc[4]+'0'-tc[6]+'0'-tc[8])* 7 -('0'-tc[1]+'0'-tc[3]+'0'-tc[5]+'0'-tc[7])) % 10 == '0'-tc[9])
        {
          sayac++;
        }
    }
  }
}


void KimlikYoket(KimlikNo k)
{
  if (k==NULL)
    return;
    free(k);
    k=NULL;

}
