/*08. Implementar uma função que escreva no terminal os números naturais, a partir de um número de início 
e fim, de forma decrescente.
Ex: (3, 11) => 11 10 9 8 7 6 5 4 3
*/

const PromptSync = require('prompt-sync')();

function decTypeNumbar(ini, limit) {
    if (IsNaN(limit) || IsNaN(ini)) throw new Error('Only numbars');
    if (limit <= 0 || ini <= 0) throw new Error('Numbers less or equals than zero are not accepted');
    if (ini < limit) throw new Error('The second numba cant be bigger than the first numba');
    let rst = '';
    for (let i = limit; i >= ini; i--) rst += i + ' ';    
    return rst;
}

function main() {
    try {
        console.log('Contar até um número decrescente');
        let cn = Number(PromptSync('Insira o valor do contador: '));
        let lm = Number(PromptSync('Insira o valor do número limite: '));
        console.log(decTypeNumbar(cn, lm));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();