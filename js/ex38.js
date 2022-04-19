/* 38. Implementar uma função que converta uma palavra para Binário. */

const PromptSync = require("prompt-sync")();

function stringToBinary(phrase) {
    let a = 0;
    let c = "";
    for (let i = 0; i < phrase.length; i++) {
        a = Number(phrase.charCodeAt(i));
        if (a >= 128) {
            c += "1";
            a -= 128;
        }
        else c += "0";

        if (a >= 64) {
            c += 1;
            a -= 64;
        }
        else c += "0";

        if (a >= 32) {
            c += "1";
            a -= 32;
        }
        else c += "0";

        if (a >= 16) {
            c += 1;
            a -= 16;
        }
        else c += "0";

        if (a >= 8) {
            c += "1";
            a -= 8;
        }
        else c += "0";

        if (a >= 4) {
            c += "1";
            a -= 4;
        }
        else c += "0";

        if (a >= 2) {
            c += "1";
            a -= 2;
        }
        else c += "0";

        if (a >= 1) {
            c += "1";
            a -= 1;
        }
        else c += "0";

        c += " ";
    }
    return c;
}

function main() {
    try {
        console.log("Converter para binário");
        let text = PromptSync('Insira o texto: ');
        console.log(stringToBinary(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();