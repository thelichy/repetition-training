public void Square(int side)
{
    if (side <= 0) throw new ArgumentException("Numbers less or equals than zero are not accepted");
    for (int row = 0; row < side; row++)
    {
        for (int i = 0; i < side; i++)
        {
            Console.Write("* ");
        }
        Console.WriteLine();
    }
}

Square(6);