void ReadInt(string? str)
{
    bool a = false;
    for (int i = 0; i < str.Length / 2; i++)
    {
        if (str![i] == str![str.Length - i - 1])
        {
            a = true;
        }
        else
        {
            a = false;
            break;
        }
    }
    if (a == true)
    {
        System.Console.WriteLine($"{str} -> да");
    }
    else
    {
        System.Console.WriteLine($"{str} -> нет");
    }
}

System.Console.WriteLine("Введите пятизначное число");
ReadInt(Console.ReadLine());
