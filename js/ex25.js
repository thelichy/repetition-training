/*25. Implementar uma função que retorne um texto que represente a forma de um triângulo a partir da 
quantidade de linhas, conforme abaixo:
*/

const PromptSync = require("prompt-sync")();

function triangle(side) {
    if (side <= 0) throw new Error("Numbers less or equals than zero are not accepted");
    let rst = "";
    for (let row = 1; row <= side; row++) {
        for (let i = side; i >= row; i--) rst += " ";
        for (let ii = 1; ii <= row; ii++) rst += row + " ";
        rst += "\n";
    }
    return rst;
}

function main() {
    try {
        console.log("Desenhar triângulo");
        let numba = Number(PromptSync('Insira o valor do lado: '))
        console.log(triangle(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${ex.Message}`);
        main();
    }
}

main();