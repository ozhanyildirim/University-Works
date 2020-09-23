/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *   Program, kimlik no header file.
 * </p>
 */
#ifndef KIMLIKNO_H
#define KIMLIKNO_H

#include <stdlib.h>
#include <stdbool.h>



struct KIMLIKNO
{
  int *(*kimlikUrett)();
  int (*TcDogrulamaa)();
  void (*KimlikYokett)(struct KIMLIKNO*);
};

typedef struct KIMLIKNO* KimlikNo;

KimlikNo KimlikOlsustur();
int *kimlikUret();
int TcDogrulama();
void KimlikYoket(KimlikNo);

#endif
