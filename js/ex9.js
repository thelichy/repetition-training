/*09. Implementar uma função que escreva no terminal os números naturais múltiplos de número informado, 
de 0 até outro número informado.
Ex1: (4, 20) => 0, 4, 8, 12, 16, 20
Ex2: (6, 20) => 6, 12, 18
*/

const PromptSync = require('prompt-sync')();

function decTypeMult(ini, limit) {
    if (isNaN(limit) || isNaN(ini)) throw new Error('Only numbars');
    if (limit <= 0 || ini <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    if (ini > limit) throw new Error('The first numba cant be bigger than the second numba');
    let rst = '';
    for (let i = 0; i <= limit; i += ini) {
        if (i % ini == 0) rst += i + ' ';
    }
    return rst;
}

function main() {
    try {
        console.log('Múlyiplos intervalados');
        let cn = Number(PromptSync('Insira o valor do múltiplo: '));
        let lm = Number(PromptSync('Insira o valor do número limite: '));
        console.log(decTypeMult(cn, lm));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();