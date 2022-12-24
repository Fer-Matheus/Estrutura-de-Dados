#include <iostream>
class Node
{
private:
    int key;
    Node *left, *right;

public:
    Node(int id){
        this->key = id;
        this->left = NULL;
        this->right = NULL;
    }
    ~Node(){
        delete this;
    }

    int getKey(){
        return key;
    }
    Node *getLeft(){
        return left;
    }
    Node setLeft(Node *node){
        left = node;
    }
    Node *getRight(){
        return right;
    }
    Node setRight(Node *node){
        right = node;
    }
};