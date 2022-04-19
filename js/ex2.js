/*2. 02. Implementar uma função que escreva no terminal os números naturais pares de 0 até um número informado.
Ex: (10) => 0 2 4 6 8 10
*/

const PromptSync = require('prompt-sync')();

function odd(limit) {
    if (IsNaN(limit)) throw new Error('Only numbars');
    if (limit <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rst = '';
    for (let i = 0; i <= limit; i += 2) rst += i + ' ';
    return rst;
}

function main() {
    try {
        console.log('Contar pares até');
        let lm = Number(PromptSync('Insira o limite: '));
        console.log(odd(lm));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();