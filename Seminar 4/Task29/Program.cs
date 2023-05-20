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
    System.Console.WriteLine("[" + string.Join(", ", input) + "]");
}

void Messages(int n)
{
    string[] Messages = { "Введите размер массива", "Введите нижнюю  границу", "Введите верхнюю границу" };
    System.Console.WriteLine(Messages[n]);
}

Messages(0);
int size = int.Parse(System.Console.ReadLine());
Messages(1);
int min = int.Parse(System.Console.ReadLine());
Messages(2);
int max = int.Parse(System.Console.ReadLine());

int[] array = FillArray(size, min, max);

PrintArray(array);