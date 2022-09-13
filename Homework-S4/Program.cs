internal class Program
{
    private static void Main(string[] args)
    {
        static void AinPowerB()  // Возводим число A в степень B
        {
            Console.WriteLine("Введите число 'a': ");
            string a = new(Console.ReadLine());
            Console.WriteLine("Введите число 'b': ");
            string b = new(Console.ReadLine());
            int c = 1;
            int x, y;
            if (int.TryParse(a, out x) && int.TryParse(b, out y) && x > 0 && y >= 0)
            {

                for (int i = 1; i < y + 1; i++)
                {
                    c *= x;
                }
                Console.Write($"{a}^{b} = ");
                Console.Write(c);
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
        
    }
}