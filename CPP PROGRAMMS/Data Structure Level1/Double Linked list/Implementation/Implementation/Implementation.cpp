//ProgrammingAdvices.com
//Mohammed Abu-Hadhoud

#include <iostream>
using namespace std;

// Create a node
class Node
{
public:
    int value;
    Node* next;
    Node* Prev;
};



int main()
{
    Node* head = NULL;

    Node* Node1 = NULL;
    Node* Node2 = NULL;
    Node* Node3 = NULL;
    Node* Node4 = NULL;
    

    Node1 = new Node();
    Node2 = new Node();
    Node3 = new Node();
    Node4 = new Node();

    Node1->value = 1;
    Node2->value = 2;
    Node3->value = 3;
    Node4->value = 4;

    Node1->next = Node2;
    Node1->Prev = NULL;

    Node2->next = Node3;
    Node2->Prev = Node1;

    Node3->next = Node4;
    Node3->Prev = Node3;

    Node4->next = NULL;
    Node4->Prev = Node3;


    head = Node1;
    while (head != NULL)
    {
        cout << head->value<<endl;
        head = head->next;
    }
    
}