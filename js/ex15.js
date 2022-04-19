/*15. Implementar uma função que retorne um texto que represente a forma de um triângulo a partir da quantidade 
de linhas, conforme abaixo:
Exemplo: 5 linhas
*/

const PromptSync = require("prompt-sync")();

function triangle(side) {
    if (side <= 0) throw new Error("Numbers less or equals than zero are not accepted");
    let rst = "";
    for (let row = 1; row <= side; row++) {
        for (let i = 1; i <= row; i++) rst += "* ";
        rst += "\n";
    }
    return rst;
}

function main() {
    try {
        console.log("Desenhar triângulo");
        let numba = Number(PromptSync('Insira a numba: '));
        console.log(triangle(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();