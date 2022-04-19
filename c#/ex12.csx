/*12. Implementar uma função que retorne um texto que represente a forma de uma linha a partir do tamanho 
de pontos que a compõem, conforme abaixo:
Exemplo: 4 pontos
* * * *
*/

public string Row(int length)
{
    if (length <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    string rst = "";
    for (int row = 0; row < length; row++) rst += "* ";
    return rst;
}

public void Main()
{
    try
    {
        Console.Write("Desenhar linha\nInsert a numba: ");
        int numba = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine(Row(numba));
    }
    catch (Exception ex)
    {
        Console.WriteLine($"Um erro ocorreu\n{ex.Message}");
        Main();
    }
}

Main();