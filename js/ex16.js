/* 16. Implementar uma função que retorne um texto que represente a forma de um triângulo
invertido a partir da quantidade de linhas, conforme abaixo:
Exemplo: 5 linhas
*/

const PromptSync = require('prompt-sync')();

function revTriangle(side) {
    if (IsNaN(side)) throw new Error('Only numbars');
    if (side <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for (let row = 0; row <= side; row++) {
        for (let i = side; i > row; i--) rst += '  ';
        for (let ii = 0; ii < row; ii++) rst += '* ';
        rst += '\n';
    }
    return rst;
}

function main() {
    try {
        console.log('Desenhar retângulo espelhado');
        let numba = Number(PromptSync('Insira a numba: '));
        console.log(revTriangle(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();