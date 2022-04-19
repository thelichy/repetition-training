/*05. Implementar uma função que escreva no terminal os números naturais de 1 até um número
 informado de forma decrescente.
Ex: (10) => 10 9 8 7 6 5 4 3 2 1
*/

const PromptSync = require('prompt-sync')();

function decTypeNumba(limit) {
    if (IsNaN(limit)) throw new Error('Only numbars');
    if (limit <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for (let i = limit; i >= 1; i--) rst += i + ' ';
    return rst;
}

function main() {
    try {
        console.log('Contar até 0');
        let cn = Number(PromptSync('Insira o valor do contador: '));
        console.log(decTypeNumba(cn));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();