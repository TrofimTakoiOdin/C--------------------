Console.WriteLine($"Введите целое число большее {1}:");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
if (b < 2)
{
    Console.WriteLine($"Укажите число большее {1} и попробуйте снова");
}
else
{
    for (int i = 2; i <= b; i++)
    {
        if (i % 2 == 0)
        {
            Console.Write($"{i} ");
        }
    }
}