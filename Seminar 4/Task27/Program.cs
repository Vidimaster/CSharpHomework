int Result(int n)
{
    int result = 0;
    while (n > 0)
    {
        result = result + n % 10;
        n = n / 10;
    }
   return result; 
}

System.Console.WriteLine("Введите число");
int input = Convert.ToInt32(Console.ReadLine());
System.Console.WriteLine($"{input} -> {Result(input)}");