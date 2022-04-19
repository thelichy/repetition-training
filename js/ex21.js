/*21. Implementar uma função que calcule a potenciação a partir de um número e do expoente. 
Obs: Essa versão da potenciação deve se preocupar apenas com números naturais, ou seja, 
inteiros positivos. Se a potência for zero, retorne 1. Se algum parâmetro for negativo, 
lançar um erro.
Ex: Potência de 3 elevado a 3 => 27
*/

const PromptSync = require("prompt-sync")();

function power(numba, exponent) {
    if (numba <= 0) throw new Error("Numbers less than zero are not accepted, except the exponent");
    if (exponent == 0) return 0;
    let numbe = numba;
    for (let i = 1; i < exponent; i++) numbe *= numba;
    return numbe;
}

function main() {
    try {
        console.log("Elevar à potência");
        let numba = Number(PromptSync('Insira um número: '));
        let numbar = Number(PromptSync('Insira a potência: '));
        console.log(power(numba, numbar));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();