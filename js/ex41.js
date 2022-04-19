/*41. Implementar uma função que implemente a criptografia ZENIT POLAR. */

const PromptSync = require("prompt-sync")();

function zenitPolar(phrase) {
    phrase = phrase.toLowerCase();
    let rst = "";
    for (let i = 0; i < phrase.length; i++) {
        let a = phrase[i];
        if (a == 'z') rst += 'p';
        else if (a == 'p') rst += 'z';
        else if (a == 'e') rst += 'o';
        else if (a == 'o') rst += 'e';
        else if (a == 'n') rst += 'l';
        else if (a == 'l') rst += 'n';
        else if (a == 'i') rst += 'a';
        else if (a == 'a') rst += 'i';
        else if (a == 't') rst += 'r';
        else if (a == 'r') rst += 't';
        else rst += a;
    }
    return rst;
}

function main() {
    try {
        console.log("Criptografia Zenit Polar");
        let text = PromptSync('Insira um texto: ');
        console.log(zenitPolar(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();