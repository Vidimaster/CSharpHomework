int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int RecAck(int m, int n)
{
    if (m == 0)
    {
        return n + 1;
    }
    else if (n == 0)
    {
        return RecAck(m - 1, 1);
    }
    else
    {
        return RecAck(m - 1, RecAck(m, n - 1));
    }
}
int sum = RecAck(ReadInt("Введите число M"), ReadInt("Введите число N"));

System.Console.WriteLine(sum);