int ReadInt(string text)
{
    System.Console.WriteLine(text);
    return Convert.ToInt32(Console.ReadLine());
}

int RecN(int M, int N)
{
    if (M == N)
    {
        return M;
    }
    else
    {
        return M + RecN(M + 1, N);
    }
}
int sum = RecN(ReadInt("Введите число M"), ReadInt("Введите число N"));

System.Console.WriteLine(sum);