/*31. Implementar uma função que conte a frequência de um digito em um número. */

const PromptSync = require('prompt-sync')();

function contarDigitos(numba, digit) {
    if (IsNaN(numba) || IsNaN(digit)) throw new Error('Only numbars');
    if (numba <= 0 || digit <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let number = String(numba);
    let dig = String(digit);
    let counter = 0;
    for (let i = 0; i < number.length; i++) {
        if (number[i] == dig) counter++;
    }
    return counter;
}

function main() {
    try {
        console.log('Contar a frequência dos dígitos');
        let numba = PromptSync('Insira o número: ');
        let digit = Number(PromptSync('Insira o dígito: '));
        console.log(contarDigitos(numba, digit));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();