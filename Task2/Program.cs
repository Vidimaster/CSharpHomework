Console.WriteLine("Enter number 1");
int a = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Enter number 2");
int b = Convert.ToInt32(Console.ReadLine());

if (a > b)
    {
        System.Console.WriteLine($"number 1 is greater than number 2: {a}");
    }
else if (a < b)
    {
        System.Console.WriteLine($"number 2 is greater than number 1: {b}");
    }
else 
    {
        System.Console.WriteLine($"Both numbers are equal: {b}");
    }
