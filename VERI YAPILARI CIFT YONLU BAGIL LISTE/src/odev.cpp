/**
* @file odev.cpp
* @description Programlarýn calýstýrýldýðý dosya.
* @course 1/A
* @assignment 1. ödev
* @date 15.08.2020
* @author Özhan Nuri YILDIRIM / B161210109
*/


#include "CIRCULARDOUBLYLINKEDLIST.hpp"

int main()
{
    CIRCULARDOUBLYLINKEDLIST Dugum;			
   
   
    Dugum.dosyaOku();					// FONKSIYONLARIN TANIMLANDIGI ODEV DOSYASI
   
    Dugum.ilkdugum(1);
     
    int x;
    for (x=2 ; x < 255 ; x++){
    Dugum.dugumEkle(x);}
    

    Dugum.sonucGoster();
    Dugum.ASCII();
    
    return 0;
}
