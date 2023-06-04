int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

void RecN(int n)
{
    if (n < 1) return;
    System.Console.Write(n + " ");
    RecN(n - 1);
    
}

RecN(ReadInt("Введите число N"));

