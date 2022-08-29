internal class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine("Введите число: ");
        int a = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Введите число: ");
        int b = Convert.ToInt32(Console.ReadLine());
        Console.WriteLine("Сумма равна: " + (a + b));
    }
}