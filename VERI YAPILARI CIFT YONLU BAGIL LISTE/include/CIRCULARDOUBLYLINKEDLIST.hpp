/**
* @file CIRCULARDOUBLYLINKEDLIST.hpp
* @description Header dosyas�
* @course 1/A
* @assignment 1. �dev
* @date 15.08.2020
* @author �zhan Nuri YILDIRIM / B161210109
*/



#ifndef CIRCULARDOUBLYLINKEDLIST_HPP
#define CIRCULARDOUBLYLINKEDLIST_HPP

#include <iostream>
#include <cstdio>
#include <cstdlib>
using namespace std;

class Node
{
public:
	int data;
	Node *next;
	Node *prev;
};

class CIRCULARDOUBLYLINKEDLIST
{

public:

	CIRCULARDOUBLYLINKEDLIST();

	 Node *head;
	Node *dugumOlustur(int);
	void ilkdugum(int);

	void insertatlast(int);
	void dugumEkle(int);
	void sonucGoster();
	void ASCII();
	int EBOB(unsigned int x,unsigned int y);
	int EbobIslemEBOB = 0;
	void dugumSil();
	void dosyaOku();
};
#endif
