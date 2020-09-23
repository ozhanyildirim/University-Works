/**
* @file AVLTree.hpp
* @description AVL agaci olusturma ve diger islemleri yaptigimiz bolum
* @course 1A
* @assignment 2
* @date 02.09.2020
* @author OZHAN NURI YILDIRIM
*/

#ifndef AVLTREE_HPP				// include bolumu
#define AVLTREE_HPP
#include <cmath>
#include <iostream>

#include <stack> 

using namespace std;

template <typename Object>
struct Node {									// dugum olusturma
	Object data;				
	Node<Object>* left;
	Node<Object>* right;
	int height;

	Node(const Object& data1, Node<Object>* left1 = NULL, Node<Object>* right1 = NULL) 
	{
		data = data1;			// veri tanımlaması
		left = left1;			// sol dugum
		right = right1;			// sag dugum
		height = 0; 		// ilk yukseligi 0 yapıyoruz
	}
};


template <typename Object>			// nesne tanımlaması
class AVLTree {						//class adi


private:
	Node<Object>* kok;

	Node<Object>* SearchandAdd(Node<Object>* bottomNode, const Object& New) {
		if (bottomNode == NULL) {										// alt dugum bossa New alt dugum ekler
			bottomNode = new Node<Object>(New);
		}
		else if (New < bottomNode->data) {				//dugumun verisinden kucukse sola ekler
			bottomNode->left = SearchandAdd(bottomNode->left, New);		//left alt çocuk yerine New bir ağaç oluşturur
				stack<string> mystack; 
			mystack.push("O"); 			// o harfi pushlamasi
			if (Height(bottomNode->left) - Height(bottomNode->right) == 2) {
			
				if (New < bottomNode->left->data)
					bottomNode = ChangeLeftKid(bottomNode);
				else {
					bottomNode->left = ChangeRightKid(bottomNode->left); //parent donus
					bottomNode = ChangeLeftKid(bottomNode);
				}
			}
		}
		else if (New > bottomNode->data) {											// yeni veri altdugumden buyukse								
			bottomNode->right = SearchandAdd(bottomNode->right, New);
			stack<string> mystack; 
			mystack.push("A"); 


			if (Height(bottomNode->right) - Height(bottomNode->left) == 2) {
				if (New > bottomNode->right->data)
					bottomNode = ChangeRightKid(bottomNode);
				else {
					bottomNode->right = ChangeLeftKid(bottomNode->right);
					bottomNode = ChangeRightKid(bottomNode);
				}
			}
		}
		else; 

	
		bottomNode->height = Height(bottomNode);
		return bottomNode;
	}
	Node<Object>* ChangeLeftKid(Node<Object>* bottomNode)		// sol cocuk degistirme
	{
		Node<Object>* tmp = bottomNode->left;
		bottomNode->left = tmp->right;
		tmp->right = bottomNode;

		// Yükseklikleri Güncelle 
		bottomNode->height = Height(bottomNode);
		tmp->height = max(Height(tmp->left), bottomNode->height) + 1;

		return tmp;
	}
	Node<Object>* ChangeRightKid(Node<Object>* bottomNode)			// sag cocuk degistirme
	{
		Node<Object>* tmp = bottomNode->right;
		bottomNode->right = tmp->left;
		tmp->left = bottomNode;

		// Yükseklikleri Güncelle 
		bottomNode->height = Height(bottomNode);
		tmp->height = max(Height(tmp->right), bottomNode->height) + 1;

		return tmp;
	}

	void AVLpost(Node<Object>* bottomNode) const {
		if (bottomNode != NULL) {
			AVLpost(bottomNode->left);
			AVLpost(bottomNode->right);
			cout << bottomNode->data << " ";

		}
	}

	int Height(Node<Object>* bottomNode)const {
		if (bottomNode == NULL)
			return -1; 			
		return 1 + max(Height(bottomNode->left), Height(bottomNode->right));
	}
	bool NodeDelete(Node<Object>*& bottomNode)
	{
		Node<Object>* deleteNode = bottomNode;

		if (bottomNode->right == NULL)		
			bottomNode = bottomNode->left;		// sag sol cocuk kontrolleri
		else if (bottomNode->left == NULL)		
			bottomNode = bottomNode->right;				
		else {									
			deleteNode = bottomNode->left;
			Node<Object>* parentNode = bottomNode;
			while (deleteNode->right != NULL) {
				parentNode = deleteNode;
				deleteNode = deleteNode->right;
			}
			bottomNode->data = deleteNode->data;
			if (parentNode == bottomNode)
				bottomNode->left = deleteNode->left;
			else
				parentNode->right = deleteNode->left;
		}
		delete deleteNode;
		return true;
	}
	bool Search(Node<Object>* bottomNode, const Object& searching) {			// arama bolumu
		if (bottomNode == NULL)
			return false;
		if (bottomNode->data == searching)
			return true;
		if (searching < bottomNode->data)
			return Search(bottomNode->left, searching);
		if (searching > bottomNode->data)
			return Search(bottomNode->right, searching);
	}


public:
	AVLTree() {
		kok = NULL;
	}

	bool Empty() const {
		return kok == NULL;
	}
	void Add(const Object& New)
	{
		kok = SearchandAdd(kok, New);
	}

	void AVLpost() const {
		AVLpost(kok);
	}

	void Levelorder()const {
		int h = Height();
		for (int level = 0; level <= h; level++)
			SeviyeyiYazdir(kok, level);
	}

	bool Searchma(const Object& searching) {
		return Search(kok, searching);
	}
	void Clear() {
		while (!Empty()) NodeDelete(kok);
	}
	int Height()const {
		return Height(kok);		 
	}

	~AVLTree() {
		Clear();
	}
};

#endif
