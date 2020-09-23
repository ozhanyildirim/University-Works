/**
* @file Manage.cpp
* @description Stackleri yonettigimiz dosya
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/



#include "Manage.hpp"
#include "Stack.hpp"
#include <iostream>



void Manage::push(Stack* stack)
{

	char key='A';
	char key1 ='O';
	char key2='Y';				// STACK ICIN HARFLENDIRMELER
	char key3= 'D';


	stack->push(key);
	stack->push(key1);		// HARFLERIN PUSHLANMASI 
	stack->push(key2);
	stack->push(key3);
	

}

void Manage::pop(Stack* stack)					// MANAGE POP ISLEMI
{	
	stack->pop();
}

void Manage::printAlla(Stack* stack)				// A HARFINI GONDERDIGIMIZ ISLEM
{
	stack->printAlla();
	
}
void Manage::printAllo(Stack* stack)				// O HARFINI GONDERDIGIMIZ ISLEM
{
	stack->printAllo();
	
}
void Manage::printAlly(Stack* stack)				// Y HARFINI GONDERDIGIMIZ ISLEM
{
	stack->printAlly();
	
}
void Manage::printAlld(Stack* stack)			// D HARFINI GONDERDIGIMIZ ISLEM
{
	stack->printAlld();
	
}
