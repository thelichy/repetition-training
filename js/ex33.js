/*33. Implementar uma função que verifique se um texto é um palíndromo. */

const PromptSync = require('prompt-sync')();

function palindromo(words) {
    let phrase = words.toLowerCase();
    let rsp = '';
    for (let i = phrase.length - 1; i >= 0; i--) rsp += phrase[i];
    if (rsp.replace(' ', '') == phrase.replace(' ', '')) return true;
    else return false;
}

function main() {
    try {
        console.log('Verificar se um texto é um palíndromo');
        let text = PromptSync('Insira o texto: ');
        console.log(palindromo(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();