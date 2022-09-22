// Программа позволяет перевернуть массив
int [] numbers = {1, 2, 3, 4, 5, 6, 7, 8, 9};
Console.WriteLine(string.Join(", ", numbers));
for (int i = 0; i < numbers.Length / 2; i++)
{
    // хотим поменять местами i-й и j-й элементы
    
    Swap (ref numbers[i], ref numbers[^(i + 1)]);
}
Console.WriteLine(string.Join(", ", numbers));
void Swap (ref int a, ref int b)
{
    int c = a;
    a = b;
    b = c;
}