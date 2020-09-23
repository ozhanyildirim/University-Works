/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *  Program, imei no header file.
 * </p>
 */
#ifndef IMEINO_H
#define IMEINO_H

#include <stdlib.h>
#include <stdbool.h>

struct IMEINO
{
  int *(*imeiUrett)();
  int (*ImeiNoDogrulaa)();
  void (*ImeiNoYokett)(struct IMEINO);
};

typedef struct IMEINO* ImeiNo;

ImeiNo imeiOlustur();
int *imeiUret();
int ImeiNoDogrula();
void ImeiNoYoket(ImeiNo);

#endif
