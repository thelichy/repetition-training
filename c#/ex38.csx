/* 38. Implementar uma função que converta uma palavra para Binário. */

public string StringToBinary(string phrase)
{
    int a = 0;
    string c = "";
    for (int i = 0; i < phrase.Length; i++)
    {
        a = Convert.ToInt32(Convert.ToChar(phrase.Substring(i, 1)));
        if (a >= 128)
        {
            c += "1";
            a -= 128;
        }
        else c += "0";

        if (a >= 64)
        {
            c += 1;
            a -= 64;
        }
        else c += "0";

        if (a >= 32)
        {
            c += "1";
            a -= 32;
        }
        else c += "0";

        if (a >= 16)
        {
            c += 1;
            a -= 16;
        }
        else c += "0";

        if (a >= 8)
        {
            c += "1";
            a -= 8;
        }
        else c += "0";

        if (a >= 4)
        {
            c += "1";
            a -= 4;
        }
        else c += "0";

        if (a >= 2)
        {
            c += "1";
            a -= 2;
        }
        else c += "0";

        if (a >= 1)
        {
            c += "1";
            a -= 1;
        }
        else c += "0";

        c += " ";
    }
    return c;
}

Console.WriteLine(StringToBinary("Careca kkk"));