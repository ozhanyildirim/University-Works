/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *  Program, rastgele kiþi üretiyor
 * </p>
 */
#include "Kisi.h"
#include "KimlikNo.h"
#include "Telefon.h"
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#include <stdbool.h>

Kisi kisiOlustur()
{
  Kisi this;
  this = (Kisi)malloc(sizeof(struct KISI));
  //isim = textten random atanacak
  //soyIsim =  "     "        "
  this->yas = yasUret(this);
  this->tcNo = KimlikOlsustur();
  this->tel = telefonOlustur();

  this->TCC=&TC;
  this->RandomIsimm=&RandomIsim;
  this->telefonn=&telefon;
  this->yasUrett=&yasUret;
  this->KisiYokett=&KisiYoket;
  return this;
}

char *RandomIsim(const Kisi k)
{
  //fgetc(); -->Dosyadan tek bir karakter okur.
  //fscanf(); -->Dosyadan biÃ§imlendirilmiÅŸ karakter dizisi okur.
  FILE *dosya;
  dosya=fopen("random_isimler..txt","r");
  char ad[4000][20];      //k->ad;
  char soyad[4000][20];   //k->soyad;
  char *isimler;
  int i=0;
  srand(time(NULL));
  int random= 0+rand()%20;
  if (dosya !=NULL)
  {
    while (!feof(dosya))
    {
      fscanf(dosya,"%s",&ad[i]);      //k->ad;
      fscanf(dosya,"%s",&soyad[i]);   //k->soyad;

      i++;
    }
  }
}

int *TC(const Kisi k)
{
  printf("%d\n", 4 );
  return k->tcNo->kimlikUrett();
}

int *telefon(const Kisi k)
{
  return k->tel->telNoUrett();
}

int yasUret(const Kisi k)
{
  srand(time(NULL));
  int yas = 0+rand()%90;
  return yas;
}

void KisiYoket(Kisi k)
{  if(k == NULL)
  return;
  free(k);
  k=NULL;
}
