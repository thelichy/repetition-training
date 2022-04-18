/* 37. Implementar uma função que verifique se uma senha é forte. Para ser forte, ela precisa ter pelo 
menos 2 caracteres especiais, 2 números e 8 digitos. */

public bool PasswordStrength(string passwd)
{
    int ch = 0;
    int num = 0;
    int dig = passwd.Length >= 8 ? 1 : 0;
    string[] numbas = {"1", "2", "3", "4", "5", "6", "7", "8", "9", "0"};
    string[] symbols = {"!", "@", "#", "$", "%", "&", "*", "+", "-", "_", "<", ">"};
    for (int i = 0; i < passwd.Length; i++)
    {
        if (numbas.Contains(passwd.Substring(i, 1))) num += 1;
        if (symbols.Contains(passwd.Substring(i, 1))) ch += 1;
    }
    ch = ch >= 2 ? 1 : 0;
    num = num >= 2 ? 1 : 0;
    if (num + ch + dig == 3) return true;
    else return false;
}

Console.WriteLine(PasswordStrength(""));