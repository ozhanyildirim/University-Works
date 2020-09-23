/**
* @file DosyaIslemi.hpp
* @description Dosya islemleri icin class 
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/

#ifndef DosyaIslemi_HPP
#define DosyaIslemi_HPP
#include "AVLTree.hpp"
#include <string>
#include <cstring>
#include <sstream>
class DosyaIslemi
{
public:										// fonksiyon public tanýmlamalarý
    void ReadFile();
    void AVLTree(string);
    string SplitString(string,int,int);
};

#endif
