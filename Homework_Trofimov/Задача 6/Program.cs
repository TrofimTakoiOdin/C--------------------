Console.WriteLine("Давайте проверим, четное ли число?");
Console.WriteLine("Введите целое число: ");
string a = Console.ReadLine();
int b = Convert.ToInt32(a);
if (b % 2 == 0)
{
    Console.WriteLine("Да");
}
else
{
    Console.WriteLine("Нет");
}
