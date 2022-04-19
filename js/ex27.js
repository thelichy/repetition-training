/*27. Implementar uma função que separe os caracteres de um texto por hífen. */

const PromptSync = require("prompt-sync")();

function separatorUltraThreeThousand(phrase, symbol) {
    let rsp = "";
    for (let i = 0; i < phrase.length; i++) {
        if (i == phrase.length - 1) rsp += phrase[i];
        else rsp += phrase[i] + symbol;
    }
    return rsp;
}

function main() {
    try {
        console.log("Separar caracteres");
        let text = PromptSync('Insira o texto: ');
        let symbol = PromptSync('Insira o símbolo: ');
        console.log(separatorUltraThreeThousand(text, symbol));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();