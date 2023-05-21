int[] FillArray(int size, int min, int max)
{
    Random rand = new Random();
    int[] array = new int[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = rand.Next(min, max);
    }
    return array;
}

void PrintArray(int[] input)
{
    System.Console.Write("[" + string.Join(", ", input) + "]" + " -> ");
}

void PrintResult(int[] input)
{
    int count = 0;
    for (int i = 0; i < input.Length; i++)
    {
        if (input[i] % 2 == 0)
        {
            count++;
        }
    }
    System.Console.WriteLine($"{count}");
}

int[] array = FillArray(20, 100, 999);
PrintArray(array);
PrintResult(array);
