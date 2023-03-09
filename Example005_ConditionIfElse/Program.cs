Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

if(username.ToLower() == "анна")
{
    Console.WriteLine("Ура, это же АННА!");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
