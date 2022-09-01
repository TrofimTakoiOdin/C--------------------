// Функция заполняет массив рандомными целыми числами от 1 до 9
void FillArray(int[] collection)
{
    int length = collection.Length;
    int index = 0;
    while (index < length)
    {
        collection[index] = new Random().Next(1, 10);
        index ++;
    }
}   
// Функция вывода массива на экран
void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    Console.WriteLine("Список элементов: ");
    while (position < count)
    {
        Console.Write(col[position] + " ");
        position ++;
    }
}
// Функция ищет индекс первого вхождения элемента в массив
int IndexOf(int[] collection, int find) 
{
    int count = collection.Length;
    int index = 0;
    int position = -1;
    string NoSuchInd = "Нет такого значения";
    while (index < count)
    {
        if (collection[index] == find)
        {
            position = index;
            break;
        }
        
        index ++;
    }
    return position;
}
// Массив array
int[] array = new int [10];
// Призываем функции
FillArray(array);
PrintArray(array);
Console.WriteLine(); // Пустая строка
// Просим пользователя ввести число, которое будем искать по индексу
Console.Write("Введите целое число число, индекс которого необходимо найти: ");
int IntElem = Convert.ToInt32(Console.ReadLine());  // Ввод пользователя
int pos = IndexOf(array, IntElem);  // Вспомогательная переменная
// Вывод на экран
Console.WriteLine($"Искомый элемент: {IntElem}");
if (pos == -1)
{
    Console.WriteLine("Такого элемента нет в массиве!");
}
else
{
    Console.WriteLine($"Позиция элемента в списке: {pos}");
}


