/*03. Implementar uma função que escreva no terminal os números naturais ímpares de 1 até um número informado.
Ex: (10) => 1 3 5 7 9
*/

const PromptSync = require('prompt-sync')();

function even(limit) {
    if (isNaN(limit)) throw new Error('Only numbars');
    if (limit <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for (let i = 1; i <= limit; i += 2) rst += i + ' ';
    return rst;
}

function main() {
    try {
        console.log('Contar ímpares');
        let lm = Number(PromptSync('Insira um limite: '));
        console.log(even(lm));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main() ;