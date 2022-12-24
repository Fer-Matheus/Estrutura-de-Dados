#include <iostream>
#include "Node.cpp"

class Tree
{
private:
    Node *root;               // Variavel que será o ponto de partida pra tree
    Node *createNode(int key) // Método privado para criar Nodes
    {
        return new Node(key);
    }
    Node *insertAux(int key, Node *root)
    {
        if (root == NULL)
        {
            Node *aux = new Node(key);
            return aux;
        }
        if (key < root->getKey())
        {
            root->setLeft(insertAux(key, root->getLeft()));
            return root;
        }
        else if (key > root->getKey())
        {
            root->setRight(insertAux(key, root->getRight()));
            return root;
        }
        return NULL;
    }
    bool searchAux(int key, Node *root) // Método que auxilia a chamada de search
    {
        if (key == root->getKey())
        {
            return true;
        }
        if (key < root->getKey())
        {
            return searchAux(key, root->getLeft());
        }
        else if (key > root->getKey())
        {
            return searchAux(key, root->getRight());
        }
        return false;
    }
    void removeNode(Node *node) // Método privado para deletar Nodes
    {
        delete node;
    }
    void removeAll(Node *node) // Método auxiliar para remoção
    {
        if (root != NULL)
        {
            removeAll(root->getLeft());
            removeAll(root->getRight());
            removeNode(root);
        }
    }
    Node *removeNodeAux(int key, Node *root) // Método para achar o node que será eliminado
    {
        if (key == root->getKey())
        {
            Node *left = root->getLeft();
            Node *right = root->getLeft();
            removeNode(root);
            left = removeReinsert(right, left);
            return left;
        }
    }
    Node *removeReinsert(Node *node, Node *root) // Método auxiliar de deleção por reinserção
    {
        if (root == NULL)
        {
            return node;
        }
        if (node->getKey() < root->getKey())
        {
            root->setLeft(removeReinsert(node, root->getLeft()));
            return root;
        }
        else if (node->getKey() > root->getKey())
        {
            root->setRight(removeReinsert(node, root->getRight()));
            return root;
        }
    }
    void showC(Node *root) // Método para mostrar de forma ascendente
    {
        if (root != NULL)
        {
            showC(root->getLeft());
            printf("%d ", root->getKey());
            showC(root->getRight());
        }
    }
    void showD(Node *root) // Método para mostrar de forma ascendente
    {
        if (root != NULL)
        {
            showD(root->getRight());
            printf("%d ", root->getKey());
            showD(root->getLeft());
        }
    }
    void showL(Node *root) // Método para mostrar de forma ascendente
    {
        if (root != NULL)
        {
            printf("%d (", root->getKey());
            showL(root->getLeft());
            showL(root->getRight());
            printf(") ");
        }
    }

public:
    Tree() // Construtor da tree
    {
        root = NULL;
    }
    ~Tree() // Deletor da tree
    {
        removeAll(root);
    }
    Node *insert(int key) // Retorna true se a inserção for bem sucedida
    {
        if (root == NULL)
        {
            root = new Node(key);
            return root;
        }
        else
        {
            if (key < root->getKey())
            {
                root->setLeft(insertAux(key, root->getLeft()));

                return root;
            }
            else if (key > root->getKey())
            {
                root->setRight(insertAux(key, root->getRight()));

                return root;
            }
        }
    }
    bool search(int key) // Retorna true se achar um node com a key passada
    {
        if (root != NULL)
        {
            return searchAux(key, root);
        }
        return false;
    }
    bool remove(int key) // Retorna true se for possivel deletar um node identificado pela key
    {
        if (root != NULL)
        {
            root = removeNodeAux(key, root);
        }
        return false;
    }
    // Mostra a tree de três formas diferentes: "C" = crescente, "D" = Decrescente, "L" = Layer
    void show(char mode)
    {
        if (root != NULL)
        {
            if (mode == 'C')
            {
                showC(root);
            }
            else if (mode == 'D')
            {
                showD(root);
            }
            else
            {
                showL(root);
            }
        }
        printf("\n");
    }
};
