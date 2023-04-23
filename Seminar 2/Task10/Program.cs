Console.WriteLine("Enter number");
int N = Convert.ToInt32(Console.ReadLine());

int seconddigit = (N - (N / 100 * 100) ) / 10;

System.Console.WriteLine($"The second digit of the number is: {N} - > {seconddigit}");