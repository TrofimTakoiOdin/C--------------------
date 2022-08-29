internal partial class Program
{
    private static void Main(string[] args)
    {
        // Дробное деление
        Console.WriteLine("Введите число: ");
        double a = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Введите число: ");
        double b = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Частное равно: " + a / b);
    }
}