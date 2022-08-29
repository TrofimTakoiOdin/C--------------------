internal class Program
{
    private static void Main(string[] args)
    {
        int a = new Random().Next(1, 11);
        Console.WriteLine("Первое число: " + a + " ");
        int b = new Random().Next(1, 11);
        Console.WriteLine("Второе число: " + b);
        Console.WriteLine("Сумма первого и второго чисел равна: " + (a + b));
    }
}