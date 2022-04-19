/* Implementar uma função que verifique se todas as vogais aparecem em um texto. */

const PromptSync = require("prompt-sync")();

function niceBoi(phrase) {
    let a = 0;
    let e = 0;
    let i = 0;
    let o = 0;
    let u = 0;
    phrase = phrase.toLowerCase();
    for (let ii = 0; ii < phrase.length; ii++)
    {
        if (phrase[i] == 'a') a = 1;
        if (phrase[i] == 'e') e = 1;
        if (phrase[i] == 'i') i = 1;
        if (phrase[i] == 'o') o = 1;
        if (phrase[i] == 'u') u = 1;
    }
    return a + e + i + o + u == 5 ? true : false;
}

function main() {
    try {
        console.log("Verificar se todas as vogais aparecem");
        let text = PromptSync('Insira o texto: ');
        console.log(niceBoi(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();