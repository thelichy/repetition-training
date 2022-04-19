/*13. Implementar uma função que retorne um texto que represente a forma de um quadrado a partir da 
quantidade de linhas, conforme abaixo:
*/

const PromptSync = require("prompt-sync")();

function square(side) {
    if (side <= 0) throw new Error("Numbers less or equals than zero are not accepted");
    let rst = "";
    for (let row = 0; row < side; row++) {
        for (let i = 0; i < side; i++) rst += "* ";
        rst += "\n";
    }
    return rst;
}

function main() {
    try {
        console.log("Desenhar quadrado");
        let numba = Number(PromptSync('Insert a numba: '));
        console.log(square(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();