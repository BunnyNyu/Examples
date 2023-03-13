//Метод создания, заполнения массива и вывода его на печать

void FillArray(int[] collection) //Метод void ничего не возвращает, return не используется
{
    int lenght = collection.Length;
    int index = 0;
    while (index < lenght)
    {
        collection[index] = new Random().Next(1, 10);
        index++;
    }
}

void PrintArray(int[] col)
{
    int count = col.Length;
    int position = 0;
    while (position < count)
    {
        Console.WriteLine(col[position]);
        position++;
    }
}

int Indexof(int[] collection, int find) //поиск индекса по заданному числу в массиве
{
    int count = collection.Length;
    int index = 0;
    int position = -1; //начало по умолчанию для случаев, если элемент не найден в отображаемом
    while (index < count)
    {
        if(collection[index] == find)
        {
            position = index;
            break; // останавливается сразу, как только найдет самый первый соответствующий
        }
        index++;
    }
    return position;
}
int[] array = new int [10]; //создание нового массива с 10-ю эллементами

FillArray(array);
PrintArray(array);
Console.WriteLine();

int pos = Indexof(array, 4); //тут указан нужный элемент для поиска
Console.WriteLine(pos);