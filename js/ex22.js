/* 22. Implementar uma função que retorne um texto que represente a forma de um losango 
a partir da quantidade de linhas, conforme abaixo:
*/

const PromptSync = require('prompt-sync')();

function losango(side) {
    if (IsNaN(side)) throw new Error('Only numbars');
    if (side <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for (let row = 0; row <= side; row++) {
        for (let i = side; i > row; i--) rst += ' ';
        for (let ii = 0; ii < row; ii++) rst += ' *';
        rst += '\n';
    } 
    for (let row = side - 1; row >= 0; row--) {
        for (let i = row; i < side; i++) rst += ' ';
        for (let ii = row; ii > 0; ii--) rst += ' *';
        rst += '\n';
    }
    return rst;
}


function losangoo(side)
{
    if (IsNaN(side)) throw new Error('Only numbars');
    if (side <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for (let row = 0; row <= side; row++) {
        for (let i = side; i > row; i--) rst += '  ';
        for (let ii = 0; ii < row; ii++) rst += ' *';
        for (let iii = 0; iii <= row; iii++) rst += ' *';
        rst += '\n';
    }
    for (let roow = side - 1; roow >= 0; roow--) {
        for (let i = side; i > roow; i--) rst += '  ';
        for (let ii = roow; ii > 0; ii--) rst += ' *';
        for (let iii = roow; iii >= 0; iii--) rst += ' *';
        rst += '\n';
    }
    return rst;
}

function main() {
    try {
        console.log('Desenhar losango');
        let ch = Number(PromptSync('Escolha: losango 1 ou 2 - '));
        let numba = Number(PromptSync('Escolha o tamanho do lado: '));
        if (ch == 1) console.log(losango(numba));
        else if (ch == 2) console.log(losangoo(numba));
        else throw new Error('Escolha apenas 1 ou 2');
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();