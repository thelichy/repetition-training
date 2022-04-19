/*39. Implementar uma função que verifique, sim ou não, se um número é primo. */

const PromptSync = require('prompt-sync')();

function numeroPrimo(numba) {
    if (IsNaN(numba)) throw new Error('Only numbars');
    if (numba <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let c = 0;
    for (let i = 2; i < numba; i++) if (numba % i == 0) c += 1;
    return c == 0 ? true : false;
}

function main() {
    try {
        console.log('Verificar se um número é primo');
        let numbas = Number(PromptSync('Insira o número: '));
        console.log(numeroPrimo(numbas));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();