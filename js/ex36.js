/* 36. Implementar uma função que converta uma palavra para ASCII. Dica: Use a função 
Convert.ToInt32(..) para C#, e charCodeAt(...) para JS. 
*/

const PromptSync = require("prompt-sync")();

function wordToAscii(word) {
    let rsp = "";
    for (let i = 0; i < word.length; i++) rsp += word.charCodeAt(i) + " ";
    return rsp;
}

function main() {
    try {
        console.log("Converter para ASCII");
        let text = PromptSync('Insira o texto: ');
        console.log(wordToAscii(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();