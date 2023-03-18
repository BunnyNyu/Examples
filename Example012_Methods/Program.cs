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
    for(int i = 0; i < count; i++)
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
        Console.WriteLine($"{i} x {j} = {i * j}"); // интерполяция строк
    }
    Console.WriteLine(); // переход на новую строку
}

// ===== Работа с текстом
// Дан текст. В тексте нужно заменить все пробелы черточками,
// маленькие буквы "к" заменять на "К",
// а большие "С" заменить маленькими "с".

string text = "- Я думаю, - сказал князь, улыбаясь, - что, "
            + "ежели бы Вас послали вместо нашего милого Винценгероде,"
            + "вы бы взяли приступом согласие прусского короля."
            + "Вы так красноречивы. Вы дадите мне чаю?";

// string s = "qwerty"
//             012
// s [3] // r

string Replace (string text, char oldValue, char newValue) // принимает строку и символ который менять и на который менять
{
    string result = String.Empty;

    int length = text.Length;
    for (int i = 0; i < length; i++)
    {
        if(text[i] == oldValue) result = result + $"{newValue}";
        else result = result + $"{text[i]}";
    }

    return result;
}

string newText = Replace(text, ' ', '|');
Console.WriteLine(newText);
Console.WriteLine();
newText = Replace(text, 'к', 'К');
Console.WriteLine(newText);

