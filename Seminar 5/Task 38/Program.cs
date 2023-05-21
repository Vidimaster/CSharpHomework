double[] FillArray(int size, int min, int max)
{
    Random rand = new Random();
    double[] array = new double[size];
    for (int i = 0; i < size; i++)
    {
        array[i] = Math.Round(rand.Next(0, 10) + rand.NextDouble(), 2);
    }
    return array;
}

void PrintArray(double[] input)
{
    System.Console.Write("[" + string.Join(" ", input) + "]" + " -> ");
}

void PrintResult(double n)
{
    System.Console.WriteLine($"{n}");
}

double MaxMinusMin(double[] input)
{
    double minval = input[0];
    double maxval = input[0];
    for (int i = 0; i < input.Length; i++)
    {
        if (minval > input[i])
        {
            minval = input[i];
        }
        if (maxval < input[i])
        {
            maxval = input[i];
        }
    }
    return Math.Round(maxval - minval, 2);

}

double[] array = FillArray(10, 1, 100);
double result = MaxMinusMin(array);
PrintArray(array);
PrintResult(result);