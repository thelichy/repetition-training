/*10. Implementar uma função que escreva no terminal o dobro dos números naturais de 1 até um número informado. 
A mensagem deve estar no formato: 'O dobro de X é Y'.
*/

const PromptSync = require('prompt-sync')();

function dobler(limit) {
    if (isNaN(limit)) throw new Error('Only numbars');
    if (limit <= 0) throw new Error('The numbas cant be minor than one');
    let rst = '';
    for (let i = 0; i < limit; i++) rst += `O dobro de ${i} é ${i*2}\n`;
    return rst;
}

function main() {
    try{
        console.log('Dobro');
        let lm = Number(PromptSync('Insira o valor do limite: '));
        console.log(dobler(lm));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();