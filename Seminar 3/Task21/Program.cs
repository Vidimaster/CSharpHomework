
string[] coordsMessages = { "Введите Ах1", "Введите Аy2", "Введите Аz3", "Введите Bх1", "Введите By2", "Введите Bz3" };
int[] coords = new int[6];

for (int i = 0; i <= 5; i++)
{
    System.Console.WriteLine($"{coordsMessages[i]}");
    coords[i] = Convert.ToInt32(Console.ReadLine());
}

double d = Math.Sqrt(Math.Pow(coords[0] - coords[3], 2) + Math.Pow(coords[1] - coords[4], 2)  + Math.Pow(coords[2] - coords[5], 2));
d = Math.Round(d, 2);
System.Console.WriteLine($"A ({coords[0]},{coords[1]},{coords[2]}); B ({coords[3]},{coords[4]},{coords[5]}) -> {d}");


