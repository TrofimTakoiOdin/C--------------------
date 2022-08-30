internal class Program
{
    private static void Main(string[] args)
    {
        int x = 7;
        int y = x++ + ++x * 2;
        Console.WriteLine(y);
    }
}
