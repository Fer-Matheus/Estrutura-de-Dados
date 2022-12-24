#include <stdio.h>
#include <stdlib.h>
#include <time.h>

struct No {
    int id;
    char nome[50];
    int idade;
    char endereco[50] ;
    int numero;
    char complemento[15];
    int cep;
    struct No *proximo;
};


int main(){

    // Alocando a lista
    struct No *lista = malloc(sizeof(struct No));

    // Caracteristicas do primeiro No
    lista->id = 1,
    lista->nome[0] = "M";
    lista->idade = 1;
    lista->endereco[0] = "A";
    lista->numero = 1;
    lista->complemento[0] = "A";
    lista->cep = 1;
    lista->proximo = NULL;

    // // Auxiliar da Adição de um novo No
    struct No *aux = lista;
    for (int i = 0; i < 100000; i++)
    {
        struct No *novo = malloc(sizeof(struct No));
        novo->id = aux->id+1;
        novo->nome[0] = "M";
        novo->idade = 1;
        novo->endereco[0] = "A";
        novo->numero = 1;
        novo->complemento[0] = "A";
        novo->cep = 1;
        aux->proximo = novo;
        aux = novo;
    }
    free(aux);

    //vetor dos teste do tempo de acesso
    double tempos[100];
    int limInf = 1, limSup = 1000;
    clock_t inicio, fim; 
    
    for (int i = 0; i < 100; i++, limInf+=1000, limSup+=1000)
    {
        inicio = clock();
        for (int k = 0; k < 100; k++)
        {
            int aleatorio = limInf+rand() % (limSup-limInf+1);
            aux = lista;
            while (aux != NULL)
            {
                if(aux->id == aleatorio) {
                    break;
                }
                aux = aux->proximo;
            }
        }
        fim = clock();
        tempos[i] = (double)(fim - inicio)*1000/CLOCKS_PER_SEC;

    }
    aux = lista;
    while (aux->proximo != NULL)
    {
        free(lista);
        lista = aux->proximo;
        aux = lista->proximo;
    }
    free(aux);
    for (int i = 0; i < 100; i++)
    {
        printf("%.0lf\n", tempos[i]);
    }
    
    return 0;
}

