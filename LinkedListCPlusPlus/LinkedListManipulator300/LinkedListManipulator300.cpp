// LinkedListManipulator300.cpp : This file contains the 'main' function. Program execution begins and ends there.
//

#include <iostream>
using namespace std;

int main()
{
    cout << "Hello World!\n";
}

// Week 2 ppt code
/*
class Node 
{
    public: string data;
    Node* next;
};

Node* head;
Node* tail;

int singleLink()
{
    head = new Node();
    head->data = "A";
    head->next = NULL;

    Node* nodeB = new Node();
    nodeB->data = "B";
    nodeB->next = NULL;

    head->next = nodeB;

    Node* nodeC = new Node();
    nodeC->data = "D";
    nodeC->next = NULL;
    nodeB->next = nodeC;

    nodeC->next = tail;
}

void Traverse()
{
    Node* p = head;
    while (p != NULL)
    {
        cout << p->data << "->";
        p = p->next;    
    }

    cout << "End" << "\n";
}

void addNode(string data)
{
    Node* newNode = new Node();
    newNode->data = data;
    newNode->next = NULL;

    tail->next = newNode;
    tail = newNode;
}

void addNodeInPosition(string data, int position)
{
    int counter = 1;
    Node* p = head;
    while (p->next != NULL && counter < position)
    {
        p = p->next;
        counter++;
    }
    Node* newNode = new Node();
    newNode->data = data;
    newNode->next = p->next;
    p->next = newNode;
}

*/

// Run program: Ctrl + F5 or Debug > Start Without Debugging menu
// Debug program: F5 or Debug > Start Debugging menu

// Tips for Getting Started: 
//   1. Use the Solution Explorer window to add/manage files
//   2. Use the Team Explorer window to connect to source control
//   3. Use the Output window to see build output and other messages
//   4. Use the Error List window to view errors
//   5. Go to Project > Add New Item to create new code files, or Project > Add Existing Item to add existing code files to the project
//   6. In the future, to open this project again, go to File > Open > Project and select the .sln file
