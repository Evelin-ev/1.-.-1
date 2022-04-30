// Программа, по-другому реагирующая на конкретное имя

Console.WriteLine("Введите ваше имя: ");
String username = Console.ReadLine();

if(username.ToLower() == "эвелина")
{
    Console.WriteLine("Привет, красотка! Всё будет хорошо! Даже если сейчас ты в этом не уверена:)");
}

if(username.ToLower() == "саня")
{
    Console.WriteLine("Привет, бро! Всё будет хорошо! Ты крутая!");
}
if(username.ToLower() == "саша")
{
    Console.WriteLine("Привет, бро! Всё будет хорошо! Ты крутая!");
}

if(username.ToLower() == "александра")
{
    Console.WriteLine("Привет, бро! Всё будет хорошо! Ты крутая!");
}

if(username.ToLower() == "санек")
{
    Console.WriteLine("Привет, бро! Всё будет хорошо! Ты крутая!");
}

if(username.ToLower() == "санёк")
{
    Console.WriteLine("Привет, бро! Всё будет хорошо! Ты крутая!");
}

if(username.ToLower() == "сашка")
{
    Console.WriteLine("Привет, бро! Всё будет хорошо! Ты крутая!");
}

else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}