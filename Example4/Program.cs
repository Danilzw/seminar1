Console.Write("Введите имя пользователя:");
string username = Console.ReadLine();

if(username.ToLower() == "Danil")
{
    Console.WriteLine("Privet Danil!123");
}
else
{
    Console.Write("Privet ");
    Console.WriteLine(username);
}