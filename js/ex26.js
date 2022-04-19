/*26. Implementar uma função que retorne um texto que represente a forma de um triângulo a partir da quantidade
 de linhas, conforme abaixo:
*/

const PromptSync = require('prompt-sync')();

function triangle(side) {
    if (IsNaN(side)) throw new Error('Only numbars');
    if (side <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    let x;
    for (let row = 1; row <= side; row++) {
        x = side;
        for (let i = side; i >= row; i--) rst += '  ';
        for (let ii = row; ii >0 ; ii--) rst += ii + ' ';
        for (let iii = 2; iii <= row; iii++) rst += iii + ' ';
        rst += '\n';
    }
    return rst;
}

function main() {
    try {
        console.log('Desenhar triângulo');
        let numba = Number(PromptSync('Insira o valor do lado: '));
        console.log(triangle(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();