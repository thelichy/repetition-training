/*12. Implementar uma função que retorne um texto que represente a forma de uma linha a partir do tamanho 
de pontos que a compõem, conforme abaixo:
Exemplo: 4 pontos
* * * *
*/

const PromptSync = require("prompt-sync")();

function row(length) {
    if (length <= 0) throw new Error("Numbers less or equals than zero are not accepted");
    let rst = "";
    for (let row = 0; row < length; row++) rst += "* ";
    return rst;
}

function main() {
    try {
        console.log("Desenhar linha");
        let numba = Number(PromptSync('Insert a numba: '));
        console.log(row(numba));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();