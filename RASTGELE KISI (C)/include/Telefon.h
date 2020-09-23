/**
 *
 * @author OZHAN NURI YILDIRIM
 * @since 26.04.2020
 * <p>
 *  Program, telefon header file.
 * </p>
 */
#ifndef TELEFON_H
#define TELEFON_H

#include <stdio.h>
#include <stdlib.h>
#include <time.h>
#include <string.h>
#include <stdbool.h>

struct TELEFON
{
  int *(*telNoUrett)();
  void (*TelefonYokett)(struct TELEFON*);
};

typedef struct TELEFON* Telefon;

Telefon telefonOlustur();
int *telNoUret();
void TelefonYoket(Telefon);


#endif
