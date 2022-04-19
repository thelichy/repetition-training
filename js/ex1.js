/*01. Implementar uma função que escreva no terminal os números naturais de 1 até um número informado.
Ex: (10) => 1 2 3 4 5 6 7 8 9 10
*/

const PromptSync = require("prompt-sync")();

function count(limit) {
    if (limit <= 0) throw new Error("Numbers less or equals than zero are not accepted");
    let rst = "";
    for (let i = 1; i <= limit; i++) rst += i + " ";
    return rst;
}

function main() {
    try {
        console.log("Contar números");
        let lm = Number(PromptSync('Insira o limite: '));
        console.log(count(lm));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();