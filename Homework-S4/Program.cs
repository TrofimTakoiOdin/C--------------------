internal class Program
{
    private static void Main(string[] args)
    {
        static void AinPowerB()  // Задача 25. Возводим число A в степень B
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
        static void DigitSum()  // Задача 27. Ищем сумму цифр числа
        {
            Console.WriteLine("Введите число, сумму цифр которого вы хотите найти: ");
            string a = new(Console.ReadLine());
            string b = a;
            int x, Counter;
            if (int.TryParse(a, out x) && x >= 0)
            {
                Counter = 0;
                for (int i = 0; i < b.Length; i++)
                {
                    
                    Counter = Counter + (int)char.GetNumericValue(b[i]);
                }
                Console.WriteLine($"Сумма цифр введенного числа: {Counter}");

            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
        
    }
}