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
        if (numbas.Contains(passwd[i]+"")) num += 1;
        if (symbols.Contains(passwd[i]+"")) ch += 1;
    }
    if ((num >= 2 ? 1 : 0) + (ch >= 2 ? 1 : 0) + dig == 3) return true;
    else return false;
}

public void Main()
{
    try
    {
        Console.Write("Verificar se a senha é forte\nInsira a senha: ");
        string text = Console.ReadLine();
        Console.WriteLine(PasswordStrength(text));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();