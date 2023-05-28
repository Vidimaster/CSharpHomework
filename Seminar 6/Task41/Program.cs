int CountNums (int[] input)
{
int length = input.Length;
int count = 0;
for (int i = 0; i < input.Length; i++)
{
    if (input[i] > 0) {count++;}
}
return count;
}

System.Console.WriteLine("Введите числа");
int[] input = Array.ConvertAll(Console.ReadLine()!.Split(), int.Parse);
int countresult = CountNums(input);
System.Console.WriteLine(string.Join(", ", input) + " -> " + countresult);
System.Console.WriteLine($"В массиве {countresult} чисел больше нуля");
