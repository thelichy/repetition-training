/*20. Implementar uma função que calcule o fatorial de um número informado.*/

const PromptSync = require('prompt-sync')();

function factorial(numba) {
    if (IsNaN(numba)) throw new Error('Only numbars');
    if (numba <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    let rt = 1;
    let msg = '';
    for (let i = numba; i >= 1; i--) {
        if (i == 1) msg += i;
        else msg += i + ' x ';
        rt *= i;
    }
    return `${msg} = ${rt}`;
}

function main() {
    try {
        console.log('Fatorial');
        let numba = Number(PromptSync('Insira um número: '));
        console.log(factorial(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();