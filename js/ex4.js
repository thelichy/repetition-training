/*04. Implementar uma função que escreva no terminal os números naturais, a partir de um número de início e fim.
Ex: (3, 11) => 3 4 5 6 7 8 9 10 11
*/

const PromptSync = require('prompt-sync')();

function typeNumbar(ini, limit) {
    if (isNaN(limit) || isNaN(ini)) throw new Error('Only numbars');
    if (limit <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    if (ini > limit) throw new Error('The first numba cant be bigger than the second numba');
    let rst = '';
    for (let i = ini; i <= limit; i++) rst += i + ' ';
    return rst;
}

function main() {
    try {
        console.log('Contar intervalo');
        let vl = Number(PromptSync('Insira o valor inicial: '));
        let lm = Number(PromptSync('Insira o valor limite: '));
        console.log(typeNumbar(vl, lm));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();