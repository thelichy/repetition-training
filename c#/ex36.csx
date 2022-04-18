/* 36. Implementar uma função que converta uma palavra para ASCII. Dica: Use a função 
Convert.ToInt32(..) para C#, e charCodeAt(...) para JS. 
*/

public string WordToAscii(string word)
{
    string rsp = "";
    for (int i = 0; i < word.Length; i++) rsp += (Convert.ToInt32(Convert.ToChar(word.Substring(i ,1)))).ToString() + " ";
    return rsp;
}

Console.WriteLine(WordToAscii("Bruno"));