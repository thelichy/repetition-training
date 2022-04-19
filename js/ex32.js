/*32. Implementar uma função que inverta os caracteres de um texto recebido. */

const PromptSync = require("prompt-sync")();

function inverter(phrase) {
    let rsp = "";
    for (let i = phrase.length - 1; i >= 0; i--) rsp += phrase[i];
    return rsp;
}

function main() {
    try {
        console.log("Inverter os caracteres");
        let text = PromptSync('Insira o texto: ');
        console.log(inverter(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();