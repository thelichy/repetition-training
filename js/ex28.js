/* 28. Implementar uma função que verifique quantas vogais aparecem em um texto. */

const PromptSync = require('prompt-sync')();

function findVowels(phrase) {
    phrase = phrase.toLowerCase();
    let rsp = 0;
    for (let i = 0; i < phrase.length; i++) {
        if (phrase[i] == 'a' || phrase[i] == 'e' || phrase[i] == 'i' || phrase[i] == 'o' || phrase[i] == 'u') rsp++;
    }
    return rsp;
}

function main() {
    try {
        console.log('Contar vogais');
        let text = PromptSync('Insira o texto: ');
        console.log(findVowels(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();