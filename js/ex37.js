/* 37. Implementar uma função que verifique se uma senha é forte. Para ser forte, ela precisa ter pelo 
menos 2 caracteres especiais, 2 números e 8 digitos. */

const PromptSync = require('prompt-sync')();

function passwordStrength(passwd) {
    let ch = 0;
    let num = 0;
    let dig = passwd.length >= 8 ? 1 : 0;
    let symbols = ['!', '@', '#', '$', '%', '&', '*', '+', '-', '_', '<', '>'];
    for (let i = 0; i < passwd.length; i++) {
        if (isNaN(Number(passwd[i]+''))) num += 1;
        if (symbols.includes(passwd[i]+'')) ch += 1;
    }
    if ((num >= 2 ? 1 : 0) + (ch >= 2 ? 1 : 0) + dig == 3) return true;
    else return false;
}

function main() {
    try {
        console.log('Verificar se a senha é forte');
        let text = PromptSync('Insira a senha: ');
        console.log(passwordStrength(text));
    } catch (err) {
        console.log(`Um erro ocorreu\n${err.message}`);
        main();
    }
}

main();