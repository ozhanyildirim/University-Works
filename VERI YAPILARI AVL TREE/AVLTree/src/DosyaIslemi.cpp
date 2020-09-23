/**
* @file DosyaIslemi.cpp
* @description	Dosya islemi icin dosyayi okuma ve kareye gore ayirma islemi
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/

#include "DosyaIslemi.hpp"
#include <fstream>

	
	void DosyaIslemi::ReadFile()				// read file islemi
{
    ifstream dosyaOku("Kisiler.txt");
    string satir = "";

    if (dosyaOku.is_open())
    {

        while (getline(dosyaOku, satir))
        {
            AVLTree(satir);
        }

        dosyaOku.close();
    }
}

string DosyaIslemi::SplitString(string _line, int _basla, int _finish)			// bosluklari ayirirken diyezi algiladigi bolum
{
    string kare = "#";
    for (int i = _basla; i < _finish; i++)
    {
        kare += _line[i];
    }
    return kare;
}

void DosyaIslemi::AVLTree(string _line)											// stringleri avl agacina ekleme
{
    if (_line[_line.length() - 1] != ' ')
    {
        _line += " ";
    }

    rf = new AVLTree();
    int basla = 0;
    int kareBul = 0;
    string numaralar[1];
    int kare;
    for (int i = 0; i < _line.length(); i++)
    {
        if (_line[i] == ' ')
        {
            kareBul = i;
            istringstream(SplitString(_line, basla, kareBul)) >> kare;
            rf->insert(kare);
            basla = kareBul + 1;
        }
    }
    rf->display();
    delete rf;
}
