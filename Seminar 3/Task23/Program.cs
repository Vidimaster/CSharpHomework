void Cubed(string text)
{
    int N = Convert.ToInt32(text);
    int[] result = new int[N + 1];
    for (int i = 1; i <= N; i++)
    {
        result[i] = Convert.ToInt32(Math.Pow(i, 3));
    }

    System.Console.Write($"{N} -> ");
    for (int i = 1; i <= N; i++)
    {
        System.Console.Write($"{result[i]}");
        if (i == N)
        {
            System.Console.WriteLine();
            break;
        }
        else
        {
            System.Console.Write($", ");
        }
    }
}
System.Console.WriteLine($"Введите число");
Cubed(Console.ReadLine());

