/**
* @file Stack.cpp
* @description Stackcpp dosyasý
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/



#include "iostream"
#include "iomanip"
#include "Stack.hpp"

using namespace std;


Stack::Stack()
{
    stk.top = -1;
}

void Stack::push(char key)
{	
    if(stk.top == STACK_SIZE - 1)			// stack dolu mu sorgulamasý
        cout << "Stack dolu.";
    else
    {
        stk.top++;
        stk.data[stk.top] = key;
    }
}

int Stack::pop()							
{
    if(stk.top == -1)
        cout << "Stack bos.";				// stack bos mu sorgulamasý
    else
    {
        int x = stk.data[stk.top];
        stk.top--;
        return x;
    }
}

void Stack::printAlla()
{
  

    cout << char(stk.data[0])<< " "  ;
    
}

void Stack::printAllo()
{
    
    

    cout << char(stk.data[1]) << " ";
 
}
void Stack::printAlly()
{
    

    cout << char(stk.data[2])<< " ";
    

}
void Stack::printAlld()
{
 

    cout << char(stk.data[3])<< " " ;

}
