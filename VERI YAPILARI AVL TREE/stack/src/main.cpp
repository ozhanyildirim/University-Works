/**
* @file	main.cpp
* @description MAIN YAPISI
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/





#include "Stack.hpp"
#include "Manage.hpp"
#include <iostream>
#include <iomanip>

int main()											// main class
{
    Manage m1;
    Stack* stk = new Stack();

   

     m1.push(stk);
         
           
    m1.printAlla(stk); 
    m1.printAllo(stk); 
    m1.printAlly(stk); 
    m1.printAlld(stk); 
 

	return EXIT_SUCCESS;
}
