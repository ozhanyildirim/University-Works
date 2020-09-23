/**
* @file Stack.hpp
* @description Stack iþlemi için class yapýsý
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/





#ifndef STACK_HPP
#define STACK_HPP

#define STACK_SIZE 8

typedef struct
{
    int data[STACK_SIZE];				// stack boyutu
    int top;
}stack;
	
class Stack					// stack class yapýsý
{
    public:
        Stack();					
        void push(char key);
        int pop();
        void printAlla();
        void printAllo();
        void printAlly();
        void printAlld();
    private:
        stack stk;
};

#endif
