Console.WriteLine("Введите три числа на одной строке через пробел: ");
string line = Console.ReadLine();
string[] splitString = line.Split(' ');
// "Ленивый способ"
//int[] numbers = new int[3];
//numbers = splitString.Select(x => int.Parse(x)).ToArray();
// int maxx = numbers.Max();
// Console.WriteLine(maxx);

// "Способ с if"
int a = Convert.ToInt32(splitString[0]);
int b = Convert.ToInt32(splitString[1]);
int c = Convert.ToInt32(splitString[2]);
if (a > b && b >= c)
    
{
    Console.WriteLine($"Максимальное значение равно: {a}");
}

else if (a > c && c >= b)
    
{
    Console.WriteLine($"Максимальное значение равно: {a}");
}
else if (b > a && a >= c)
{
    Console.WriteLine($"Максимальное значение равно: {b}");
}
else if (b > c && c >= a)
{    
    Console.WriteLine($"Максимальное значение равно: {b}");
}
else if (c > a && a >= b)
    
{
    Console.WriteLine($"Максимальное значение равно: {c}");
}
else
    
{
    Console.WriteLine($"Максимальное значение равно: {c}");
}