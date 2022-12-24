#include <stdio.h>
#include <stdlib.h>
#define true 1
#define false 0

typedef int bool;
typedef int Key;

typedef struct aux
{
    Key key;
    /*dados podem vir aqui*/
    struct aux *left, *right;
} No;

typedef No *Pont;

Pont inicialize()
{
    return NULL;
}
Pont insert(Pont root, Pont no)
{
    if (root == NULL)
        return (no);
    if (root->key < no->key)
    {
        root->right = insert(root->right, no);
    }
    else if(root->key > no->key)
    {
        root->left = insert(root->left, no);
    }
    return root;
}

Pont delectReins(int idNo, Pont root)
{
}
Pont createNo(int key)
{
    Pont no = (Pont)malloc(sizeof(No));
    no->key = key;
    no->left = NULL;
    no->right = NULL;
    return no;
}

Pont search(int key, Pont root)
{
    if (root == NULL)
        return NULL;
    if (root->key == key)
    {
        return root;
    }
    if (root->key < key)
    {
        return search(key, root->right);
    }
    return search(key, root->left);
}

int contNo(Pont root)
{
    if (root == NULL)
        return 0;
    else
    {
        return contNo(root->left) + 1 + contNo(root->right);
    }
}
void showC(Pont root)
{
    if (root != NULL)
    {
        showC(root->left);
        printf("%i ", root->key);
        showC(root->right);
    }
}
void showD(Pont root)
{
    if (root != NULL)
    {
        showD(root->right);
        printf("%i ", root->key);
        showD(root->left);
    }
}
void showL(Pont root)
{
    if (root != NULL)
    {
        printf("%i ", root->key);
        printf(" ( ");
        showL(root->right);
        showL(root->left);
        printf(" ) ");
    }
}
Pont destruct(Pont root)
{
    if (root != NULL)
    {
        destruct(root->left);
        destruct(root->right);
        free(root);
    }
}
int main()
{
    int values[] = {4, 32, 22, 55, 36, 1, 57, 29, 49, 39, 81, 91, 26, 54, 77, 91, 11, 32, 54};
    int lenght = sizeof(values) / sizeof(int);
    Pont no, root = inicialize();
    for (int i = 0; i < lenght; i++)
    {
        no = createNo(values[i]);
        root = insert(root, no);
    }

    // no = search(25, root);
    // if (no != NULL)
    //     printf("%d\n", no->key);
    // else
    //     printf("Item nao encontrado!\n");

    // int cont = contNo(root);

    // printf("Existem %d nos na minha arvore.\n", cont);
    printf("Acendente:\n");
    showC(root);
    // printf("\n");
    // showD(root);
    // printf("\n");
    // showL(root);
    // printf("\n");
    root = destruct(root);
    // showC(root);

    return 0;
}