/*34. Implementar uma função que inverta os digitos de um número recebido. */

const PromptSync = require('prompt-sync')();

function inverter(numba) {
    if (isNaN(numba)) throw new Error('Only numbars');
    let rsp = '';
    let phrase = String(numba);
    for (let i = phrase.length - 1; i >= 0; i--) rsp += phrase[i];
    return Number(rsp);
}

function main() {
    try {
        console.log('Inverter os dígitos de um número');
        let numba = Number(PromptSync('Insira o número: '));
        console.log(inverter(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();