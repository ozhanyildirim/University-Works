/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *  program rastgele kisi olusturuyor
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

RastgeleKisi RastgeleKisiOlustur()
{
  RastgeleKisi this;
  this = (RastgeleKisi)malloc(sizeof(struct RASTGELEKISI));
  this->k =  kisiOlustur();
  this->i = imeiOlustur();
  this->RastgeleKisiUrett=&RastgeleKisiUret;
  this->RastgeleKisiYokett=&RastgeleKisiYoket;
  return this;
}

void RastgeleKisiUret(const RastgeleKisi r)
{

  FILE *dosya;

  fopen("program.txt","a");
  fprintf(dosya,"%d",3);
  for (int j = 0; j < 11; j++)
  {printf("asd ");
   fprintf(dosya,"%d",r->k->TCC(r->k)[j]);
   printf("asd 2");
  }

  fprintf(dosya," ");
  fprintf(dosya,"%s",r->k->RandomIsimm(r->k) );
  fprintf(dosya," ");
  fprintf(dosya,"%d",r->k->yasUrett(r->k));
  fprintf(dosya," ");

  for (int i = 0; i < 12; i++)
  {
    fprintf(dosya,"%d",r->k->telefonn(r->k)[i]);
  }
  fprintf(dosya," ");
  fprintf(dosya,"(");
  for (int j = 0; j < 15; j++)
  {
    fprintf(dosya,"%d",r->i->imeiUrett()[j]);
  }
  fprintf(dosya,")\n");
  fclose(dosya);

}

void RastgeleKisiYoket(RastgeleKisi k)
{  if(k == NULL)
  return;
  free(k);
  k=NULL;
}
