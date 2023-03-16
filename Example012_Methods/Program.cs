// Виды методов

// Вид 1 - ничего не возвращают, ничего не принимают
void Method1()                              //
{                                           // тело метода
    Console.WriteLine("Что-то написать");   //
}                                           //

Method1(); // вызов метода таким образом





// Вид 2 - принимают какие-то аргументы, но ничего не возвращают
void Method2(string msg) // Вариант 1
{
    Console.WriteLine(msg);
}
// Method2("Текст сообщения");    // либо так
Method2(msg: "Текст сообщения")ж; // либо, именнованный метод (нужно, если метод принимает какое-то количество аргументов)

void Method21(string msg, int count) // Вариант 2
{
    int i = 0;
    while (i < count)
    {
        Console.WriteLine(msg);
        i++;
    }
}
Method21("Текст", 4); // так: текст, количество повторов сообщения
Method21(msg: "Текст", count: 4); // или конкретизируя агумент (аргументы можно писать не по порядку)





// Вид 3 - что-то возвращают, ничего не принимают
int Method3() // Обязательно указываем тип данных перед методом
{
    return DateTime.Now.Year;
}
int year = Method3();
Console.WriteLine(year);




// Вид 4 - что-то принимают и что-то возвращают
string Method4(int count, string text)
{
    int i = 0;
    string result = string.Empty; // string.Empty - пустая строка

    while (i < count)
    {
        result = result + text;
        i++;
    }
    return result;
}
string res = Method4(10, "абракадабра"); // 10 раз напишет (склеит) текст в ковычках
Console.WriteLine(res);




// Вид 4 - тот же, но через for
string Method4(int count, string text)
{
    
    string result = string.Empty;
    for(int i = 0; (i < count; i++)
    {
        result = result + text;
    }
    return result;
}
string res = Method4(10, "абракадабра"); 
Console.WriteLine(res);





// Цикл в цикле
for(int i = 2; i <= 10; i++)
{
    for (int j = 2; j <=10; j++)
    {
        Console.WriteLine($"{i} x {j} = {i * j}");
    }
    Console.WriteLine(); // переход на новую строку
}
