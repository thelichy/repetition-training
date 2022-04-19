/* 40. Implementar uma função que verifique qual é o número da sequência de 
fibonacci, a partir de uma posição informada.
Sequência Fibonacci: 1, 1, 2, 3, 5, 8, 13, 21, 34, 55, 89
*/

const PromptSync = require('prompt-sync')();

function fibonacci(pos) {
    if (isNaN(pos)) throw new Error('Only numbars');
    if (pos <= 2) throw new Error('Numbers less or equals than 2 are not accepted');
    let numba = 1;
    let prevnumba = 1;
    let rst = 0;
    let rsp = '1, 1, ';
    for (let i = 2; i < pos; i++) {
        rst = numba + prevnumba;
        if (i == pos - 1) rsp += rst;
        else rsp += rst + ', ';
        prevnumba = numba;
        numba = rst;
    }
    return rsp;
}

function main() {
    try {
        console.log('Sequência de Fibonacci');
        let numba = Number(PromptSync('Insira a posição: '));
        console.log(fibonacci(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();