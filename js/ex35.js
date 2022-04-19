/*35. Implementar uma função que verifique se um número é um palíndromo. */

const PromptSync = require('prompt-sync')();

function palindromo(numba) {
    if (IsNaN(numba)) throw new Error('Only numbars');
    if (numba <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rsp = '';
    let phrase = numba + '';
    for (let i = phrase.length - 1; i >= 0; i--) rsp += phrase[i];
    if (rsp.replace(' ', '') == phrase.replace(' ', '')) return true;
    else return false;
}

function main() {
    try {
        console.log('Verificar se um número é um palíndromo');
        let numba = Number(PromptSync('Insira o número: '));
        console.log(palindromo(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();