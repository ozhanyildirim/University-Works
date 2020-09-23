/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *  program rastgele telefon olusturuyor
 * </p>
 */
#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#include "Telefon.h"



Telefon telefonOlustur()
{
  Telefon this;
  this = (Telefon)malloc(sizeof(struct TELEFON));
  this->telNoUrett=&telNoUret;
  this->TelefonYokett=&TelefonYoket;
  return this;
}

int *telNoUret()
{
  int tel [12];
  srand(time(NULL));

  //int yas = 0+rand()%90;

  tel[0] = 0;
  tel[1] = 5;

  for (int i = 2; i < 4; i++)
  {
    tel[i] = 0+rand()%3;
    tel[i] += 3;
   }

  for (int i = 3; i <= 11; i++)
  {
    tel[i] = 0+rand()%10;
  }

  for (int i = 0; i < 11; i++)
  {
    printf("%d",tel[i]);
  }

  int *p;
  p = tel;
  return p;
}

void TelefonYoket(Telefon t)
{
  if (t==NULL)
  return;
  free(t);
  t=NULL;
}
