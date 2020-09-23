/**
* @file Manage.hpp
* @description Manage islemi icin class
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/


#include "Stack.hpp"
#ifndef MANAGE_HPP
#define MANAGE_HPP

class Manage
{
public:
    void push(Stack* stack);					// manage islemleri icin fonksiyonlar
    void pop(Stack* stack);
    void printAlla(Stack* stack);
    void printAllo(Stack* stack);
    void printAlly(Stack* stack);
    void printAlld(Stack* stack);
};

#endif
