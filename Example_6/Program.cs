// Программа, по-другому реагирующая на конкретное имя

Console.WriteLine("Введите ваше имя: ");
String username = Console.ReadLine();

if(username.ToLower() == "эвелина")
{
    Console.WriteLine("Привет, красотка! Всё будет хорошо! Даже если сейчас ты в этом не уверена:)");
}
else
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}