/*07. Implementar uma função que escreva no terminal os números naturais ímpares de 1 até um número
 informado de forma decrescente.
Ex: (10) => 9 7 5 3 1
*/

const PromptSync = require('prompt-sync')();

function decTypeEvenNumba(limit) {
    if (isNaN(limit)) throw new Error('Only numbars');
    if (limit <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for (let i = (limit % 2 != 0 ? limit : limit - 1); i > 0 ; i--) rst += i + ' ';
    return rst;
}

function main() {
    try {
        console.log('Contar ímpares até 0');
        let cn = Number(PromptSync('Insira o valor do contador: '));
        console.log(decTypeEvenNumba(cn));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();