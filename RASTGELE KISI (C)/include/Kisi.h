/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *   Program, kisi header file.
 * </p>
 */
#ifndef KISI_H
#define KISI_H

#include "KimlikNo.h"
#include "Telefon.h"

struct KISI
{
  char *ad;
  char *soyad;
  int yas;
  KimlikNo tcNo;
  Telefon tel;

  char *(*RandomIsimm)(struct KISI*);
  int *(*TCC)(struct KISI*);
  int *(*telefonn)(struct KISI*);
  int (*yasUrett)(struct KISI*);
  void (*KisiYokett)(struct KISI*);

};

typedef struct KISI* Kisi;

Kisi kisiOlustur();
char *RandomIsim(const Kisi);
int *TC(const Kisi);
int *telefon(const Kisi);
int yasUret(const Kisi);
void KisiYoket(Kisi);

#endif
