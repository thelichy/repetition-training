/*30. Implementar uma função que conte a frequência de um caractere em um texto. */

const PromptSync = require('prompt-sync')();

function contarFrequencia(phrase, character) {
    phrase = phrase.toLowerCase();
    let counter = 0;
    for (let i = 0; i < phrase.length; i++) if (phrase[i] == character) counter++;
    return counter;
}

function main() {
    try {
        console.log('Contar a frequência de um caractere');
        let text = PromptSync('Insira o texto: ');
        let character = PromptSync('Insira o caractere: ');
        console.log(contarFrequencia(text, character));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();