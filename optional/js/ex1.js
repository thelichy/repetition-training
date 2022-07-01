/* 01. Implementar uma função que recorte um texto a partir de uma posição e da quantidade de caracteres para recortar.*/

const prompt = require('prompt-sync')();

function substring(phrase, pos, comp) {
    if (pos < 0 || comp < 1 || comp > phrase.length - pos + 1) throw new Error('Invalid values');

    let rst = '';
    for(let i = pos; i <= comp; i++) rst += phrase[i];
    return rst;
}

function main() {
    try {
        console.log('Cut');
        let ph = prompt('String: ');
        let numba = Number(prompt('Position: '));
        let numbar = Number(prompt('Length: '));
        console.log(substring(ph, numba, numbar));
    } catch (err) {
        console.log($`\nAn error has ocurred: {ex.Message}\n`);
        main();
    } finally {
        let repet  = prompt('Again? [Y/n] ');
        if (repet == 'n') {
            console.log('Goodbay');   
        } else if (repet == '' || repet == 'y') {
            console.log('\n');
            main();
        }
    }
}

main();
