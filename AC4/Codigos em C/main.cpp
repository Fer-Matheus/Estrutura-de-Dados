#include <iostream>
#include "Tree.cpp"

using namespace std;

int main()
{
    int values[] = {39, 32, 22, 55, 36, 1, 57, 29, 49, 4, 81, 91, 26, 54, 77, 91, 11, 32, 54};
    Tree *tree = new Tree();
    int tam = sizeof(values) / sizeof(int);
    for (int i = 0; i < tam; i++)
    {
        tree->insert(values[i]);
    }
    tree->show('C');
    tree->show('D');
    tree->show('L');

    tree->~Tree();

    return 0;
}