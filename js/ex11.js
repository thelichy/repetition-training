/*11. Implementar uma função que escreva no terminal a tabuada de um número informado. A
 mensagem deve estar no formato: 'A x B = X'.
*/

const PromptSync = require('prompt-sync')();

function table(firstNumba, secondNumba) {
    if (IsNaN(secondNumba) || IsNaN(firstNumba)) throw new Error('Only numbars');
    if (secondNumba <= 0 || firstNumba <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for(let i = 1; secondNumba >= i; i++) rst += `${firstNumba} x ${i} = ${i * firstNumba}\n`;
    return rst;
}

function main() {
    try {
        console.log('Tabuada');
        let numba = Number(PromptSync('Insert a numba: '));
        let numbaa = Number(PromptSync('insert a other numba: '));
        table(numba, numbaa);   
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();