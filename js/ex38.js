/* 38. Implementar uma função que converta uma palavra para Binário. */

const PromptSync = require('prompt-sync')();

function stringToBinary(phrase) {
    let a = 0;
    let c = '';
    for (let i = 0; i < phrase.length; i++) {
        a = Number(phrase.charCodeAt(i));
        for (let ii = 128; ii >= 1; ii /= 2) {
            if (a >= ii) {
                c += '1';
                a -= ii;
            } else c += '0';
        }
        c += " ";
    }
    return c;
}

function main() {
    try {
        console.log('Converter para binário');
        let text = PromptSync('Insira o texto: ');
        console.log(stringToBinary(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();