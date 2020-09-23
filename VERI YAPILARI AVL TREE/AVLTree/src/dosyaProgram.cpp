/**
* @file dosyaProgram.hpp
* @description dosyalama islemi icin dosya okuma
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/

#include "DosyaIslemi.hpp"

int main()
{
   
    DosyaIslemi *dosya = new DosyaIslemi();		 //  DOSYA OKUMA VE AVL OLUSTURMA
    
    dosya->ReadFile();
    
    delete dosya;			// cop olusmasini engellemek icin siliyoruz
    
	return 0;
}
