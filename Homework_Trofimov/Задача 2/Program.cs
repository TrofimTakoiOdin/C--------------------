Console.WriteLine("Введите два числа, каждое на отдельной строке: ");
int a = Convert.ToInt32(Console.ReadLine());
int b = Convert.ToInt32(Console.ReadLine());
if (a < b)
{
    Console.WriteLine($"max = {b}");
    Console.WriteLine($"min = {a}");
}
else if (a == b)
{
    Console.WriteLine("Числа равны");
}
else
{
    Console.WriteLine($"max = {a}");
    Console.WriteLine($"min = {b}");
}