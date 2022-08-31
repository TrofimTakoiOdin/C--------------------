using System;

public class MainClass
{
    public static void Main()
    {
        Console.WriteLine("Введите четыре целых числа через пробел в одну строку: ");
        string line = Console.ReadLine();
        string[] splitString = line.Split(' ');

        int a = Convert.ToInt32(splitString[0]);
        int b = Convert.ToInt32(splitString[1]);
        int c = Convert.ToInt32(splitString[2]);
        int d = Convert.ToInt32(splitString[3]);

        int minValue = a;
        if (b < minValue)
        {
            minValue = b;
        }
        if (c < minValue)
        {
            minValue = c;
        }
        if (d < minValue)
        {
            minValue = d;
        }
        
        int maxValue = a;

        if (b > maxValue)
        {
            maxValue = b;
        }
        if (c > maxValue)
        {
            maxValue = c;
        }
        if (d > maxValue)
        {
            maxValue = d;
        }

        Console.WriteLine($"Наименьшее число - {minValue}");
        Console.WriteLine($"Наибольшее число - {maxValue}");


        

        

    }
}
