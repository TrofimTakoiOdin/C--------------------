internal partial class Program
{
    private static void Main(string[] args)
    {
        void FiveDigitPalindrome()
        {
            Console.WriteLine("Введите пятизначное число: ");
            string a = new(Console.ReadLine());
            int x;
            if (int.TryParse(a, out x) && x > 9999 && x < 100000)
            {
                string b = new(string.Join("", a.Reverse()));
                if (a == b)
                {
                    Console.WriteLine("Да, это палиндром");
                }
                else
                {
                    Console.WriteLine("Нет, это не палиндром!");
                }
            }
            else
            {
                Console.WriteLine("Вы ввели что-то не то!");
            }
        }
    }
    
}