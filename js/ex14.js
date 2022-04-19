/*14. Implementar uma função que retorne um texto que represente a forma de um retângulo a partir da quantidade de 
linhas e colunas, conforme abaixo:
Exemplo: 4 linhas e 2 colunas
*/

const PromptSync = require('prompt-sync')();

function rectangle(side, height) {
    if (IsNaN(side) || IsNaN(height)) throw new Error('Only numbars');
    if (side <= 0 || height <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for (let i = 0; i < side; i++)
    {
        for (let ii = 0; i < height; ii++) rst += '* ';
        rst += '\n';
    }
    return rst;
}

function main() {
    try {
        console.log('Desenhar retângulo');
        let numba = Number(PromptSync('Insira a base: '));
        let numbar = Number(PromptSync('Insira a altura: '));
        console.log(rectangle(numba, numbar));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();