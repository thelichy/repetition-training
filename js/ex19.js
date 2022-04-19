/*19. Implementar uma função que calcule a soma dos números ímpares naturais de 1 até
um número informado.
*/

const PromptSync = require('prompt-sync')();

function sum(limit) {
    if (isNaN(limit)) throw new Error('Only numbars');
    if (limit <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rt = 0;
    let msg = '';
    for (let i = 1; i <= limit; i += 2) {
        if (i == limit) msg += i;
        else msg += i + ' + ';
        rt += i;
    }
    return `${msg} = ${rt}`;
}

function main() {
    try {
        console.log('Somar ímpares até');
        let numba = Number(PromptSync('Insira o limite: '));
        console.log(sum(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();