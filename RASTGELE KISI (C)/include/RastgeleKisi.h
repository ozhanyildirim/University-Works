/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *  Program, rastgele kisi header file.
 * </p>
 */
#ifndef RASTGELEKISI_H
#define RASTGELEKISI_H

#include "Kisi.h"
#include "ImeiNo.h"

struct RASTGELEKISI
{
  Kisi k;
  ImeiNo i;
  void (*RastgeleKisiUrett)(struct RASTGELEKISI*);
  void (*RastgeleKisiYokett)(struct RASTGELEKISI*);

};

typedef struct RASTGELEKISI* RastgeleKisi;

RastgeleKisi RastgeleKisiOlustur();
void RastgeleKisiUret(const RastgeleKisi );
void RastgeleKisiYoket(const RastgeleKisi);

#endif
