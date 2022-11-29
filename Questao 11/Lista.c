#include <stdio.h>
#include <stdlib.h>

struct No{
    int id;
    char[50] nome;
    int idade;
    char[50] endereco;
    int numero;
    char[15] complemento;
    int cep;
    No *proximo;
};

int main(){
    No lista = malloc(sizeof(No));
    lista->id = 1;
    lista->id = 1;
    lista->id = 1;
    lista->id = 1;
    lista->id = 1;
    lista->id = 'c';
    lista->cep = 2;
    lista->proximo = null;
    return 0;
}