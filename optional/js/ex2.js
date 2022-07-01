/* 02. Implementar uma função que substitua um caracter por outro em um texto. */

const prompt = require('prompt-sync')();

function replace(phrase, com, rpl) {
    let rst = "";
    for (let i = 0; i < phrase.length; i++) {
        if (phrase[i] == com) rst += rpl;
        else rst += phrase[i];
    }
    return rst;
}

function main() {
    try {
        console.log("Cut");
        let ph = prompt('String: ');
        let cchar = prompt('Common char: ');
        let rchar = prompt('Replacer: ');
        console.log(replace(ph, cchar, rchar));
    } catch (err) {
        console.log($`\nAn error has ocurred: {err.message}\n`);
        main();
    } finally {
        let repet = prompt('Again? [Y/n] ');
        if (repet == "n") {
            console.log("Goodbay");
        } else if (repet == "" || repet == "y") {
            main();
        }
    }
}

main();
