/**
* @file CIRCULARDOUBLYLINKEDLIST.cpp
* @description ANA DOSYA.
* @course 1/A
* @assignment 1. ödev
* @date 15.08.2020
* @author Özhan Nuri YILDIRIM / B161210109
*/


#include "CIRCULARDOUBLYLINKEDLIST.hpp"
#include <iostream>
#include <fstream>
#include <sstream>

using namespace std;


CIRCULARDOUBLYLINKEDLIST::CIRCULARDOUBLYLINKEDLIST()
{
    head = NULL;
}
int CIRCULARDOUBLYLINKEDLIST::EBOB(unsigned int x,unsigned int y)			// ebob fonksiyon tanýmý
{         
   { 
     int i=(x>=y?y:x); 
   
     while (i>=1) 
     { 
        if (x%i==0 && y%i==0) 
           break; 
        i--; 
     } 
     return i; 
  } 
   
                  
}


Node *CIRCULARDOUBLYLINKEDLIST::dugumOlustur(int data)			// düðüm aluþturma fonksiyonu
{
    Node *ilk;
    
    ilk = new Node;
    
    ilk->data = data;
    
    ilk->next = NULL;
    
    ilk->prev = NULL;
    
    return ilk;
    
}

void CIRCULARDOUBLYLINKEDLIST::ilkdugum(int data)

{
    Node *yeninode;
    yeninode = dugumOlustur(data);				// ilk düðüm oluþturma 

    if (head == NULL)
    {
        yeninode->next = yeninode;
        yeninode->prev = yeninode;
        head = yeninode;
    }
    else
    {
        Node *temp;
        temp = head;

        yeninode->next = temp;
        yeninode->prev = temp->prev;
        temp->prev->next = yeninode;
        temp->prev = yeninode;

        head = yeninode;
    }
}

void CIRCULARDOUBLYLINKEDLIST::sonucGoster()			// temp datalarýnýn ekranda gösterilmesi
{
        Node *temp , *x;

        cout << endl;

        temp = head;
    
    
        while (temp->next != head)
        {
            cout << temp->data <<" |<->| ";
            temp = temp->next;


            
        }
        
        cout << temp->data;

            
     
    
}
void CIRCULARDOUBLYLINKEDLIST::ASCII()					// sonda gösterilen ascii kodlarýnýn gösterilmesi
{
    
    cout<< "\n \nASCII KODLARI :";
    cout<< "\n------------------------------------------------------------------------------------";
        Node *temp , *x;

        cout << endl;

        temp = head;
    
        
        while (temp->next != head)
        {
           
            temp=temp->next;
            cout<< char(temp->data) << " " ;

            
        }
        
    cout<< "\n-----------------------------------------------------------------------------------";
}

void CIRCULARDOUBLYLINKEDLIST::dosyaOku()
{
     
    
	    fstream file; 						// 0-255 arasý sayýlarý alma fonksiyonu
	    string  t, q, filename;
    string word = "";
  
    // filename of the file 
    filename = "Sayilar.txt"; 
  
    // opening file 
    file.open(filename.c_str()); 
   stringstream geek(word); 
            int x = 0; 
            geek >> x; 
    // extracting words from the file 
    while (file >> x) 
    { 
           
      //  cout << x << endl; 
    } 
  
}

void CIRCULARDOUBLYLINKEDLIST::dugumSil()
{
    Node *head,*n;

    if(head == n)
    {
        if(head->next==NULL)
        {
            cout << "YALNIZCA 1 DUGUM VAR LISTE BOS BIRAKILAMAZ";				// delete fonksiyonu

            return;
        }
       
        
        head->data = head->next->data;  
  
        n = head->next;  
  
        head->next = head->next->next;  
  
        free(n);  
  
        return;  
    }
}
void CIRCULARDOUBLYLINKEDLIST::dugumEkle(int data)				// düðüm ekleme
{

    Node *temp;
    temp = head;

       
       
    int EbobTempIslem = EBOB(temp->data, data);
    cout << "EBOB SONUCU : " << EbobTempIslem << endl;


    if (EbobTempIslem > EbobIslemEBOB)
    {
        EbobIslemEBOB = EbobTempIslem;
        int tempModu = temp->data % data;

        int a = char(temp->data);


    

        if (tempModu == 0)
        {
            Node *yeninode, *dugum1, *dugum2;
            yeninode = dugumOlustur(data);
            dugum1 = temp;

            dugum2 = dugum1->next;

            dugum1->next = yeninode;

            yeninode->next = dugum2;

            dugum2->prev = yeninode;

            yeninode->prev = dugum1;

            head = dugum1;
        }
        else
        {
            for (int i = 0; i < tempModu; i++)
            {
                if (temp == head)
                {
                    Node *yeninode, *dugum1, *dugum2 ,*x;

                    yeninode = dugumOlustur(data);
                    dugum1 = head;

                    dugum2 = dugum1->prev;
                    dugum1->prev = yeninode;
                    yeninode->prev = dugum2;

                    dugum2->next = yeninode;
                    yeninode->next = dugum1;

                    head=yeninode;
                    
                    break;
                }
                else
                {
                    temp = temp->prev;
                }
            }
        }
    }
    else
    {
        while (EbobTempIslem < EbobIslemEBOB)
        {
            temp = temp->next;
            EbobTempIslem = EBOB(temp->data, data);
            if (temp->next == head)
            {
                break;
            }
        }

        int tempModu = data % temp->data; // TEMPIN MODUNU ALMA ISLLEMI

        cout << "MOD SONUCU :  " << tempModu << endl;		// MODU YAZDIRMA

        temp = head;

        for (int i = 0; i < tempModu; i++)
        {
            temp = temp->prev;
         
        }
                if (temp == head)
                {
                    Node *yeninode, *dugum1, *dugum2 ,*x;
                    yeninode = dugumOlustur(data);
                    
                    dugum1 = head->prev;
                    yeninode -> next = temp;
                    yeninode -> prev = dugum1;
                    dugum1->next = temp->prev=yeninode;
                    head=yeninode;
                    
                   
                   dugumSil();     // HAFIZA SIFIRLAMA

                   
                }
                else
                {
                  Node *a ,*b,*yeninode;
                   yeninode = dugumOlustur(data);
                  a=temp;
                  b=a->prev;

                  a->prev = yeninode;
                  b->next = yeninode;

                  yeninode ->next = a;
                  yeninode ->prev = b;
                  dugumSil();     // HAFIZA SIFIRLAMA
              

                }

        dugumSil();     // HAFIZA SIFIRLAMA
       
    }


}



