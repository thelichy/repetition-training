// Implementar uma função que recorte um texto a partir de uma posição e da quantidade de caracteres para recortar.

#include <stdio.h>
#include <string.h>

char cut(char *string, int pos, int qt)
{
    int max = strlen(string);
    char nstring[max];
    if (qt - pos > max - 1)
        return *" "; // temp
    for (int i = pos; (i < qt) && (string[i] != '\0'); i++) {
        nstring[i - pos] = string[i];
    }
    return *nstring;
}

int main(int argc, char *argv[])
{
    char string[50];
    int pos, qtd;
    printf("Insira string: ");
    scanf("%s", string);
    printf("Insira posição: ");
    scanf("%i", pos);
    printf("Insira quantidade de caracteres: ");
    scanf("%i", qtd);
    char rst = cut(string, pos, qtd);
    printf("%s", rst);
}
