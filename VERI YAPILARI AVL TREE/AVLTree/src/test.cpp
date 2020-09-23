/**
* @file test.cpp
* @description AVL treeina ekleme yaptigimiz main fonksiyonu
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/



#include "AVLTree.hpp"
#include <stack> 

int main(){
	AVLTree<int> *tree = new AVLTree<int>();

	tree->Add(28);
	tree->Add(40);
	tree->Add(46);
	tree->Add(33);
	tree->Add(34);
	tree->Add(36);

	
 	//stack<string> mystack; 
   //  mystack.push("A"); 
    // mystack.push("O"); 
    // mystack.push("D"); 
    // mystack.push("Y"); 
    //Stack becomes A, O, Y, D 


    //cout << endl << mystack.push(); 

	cout<<endl<<"AVL AGACI :";
	
	tree->AVLpost();
	
	cout<<endl<<endl;	
	delete tree;
	return 0;
}
