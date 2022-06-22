Console.Write("Введите имя пользователя: ");
string username = Console.ReadLine();

/*if (username == "Маша") //если введенное имя == Маша, но только если вводят также с большой буквы*/
if (username.ToLower() == "маша") //если введенное имя == Маша с любым регистром

{
    Console.WriteLine("Ура, это же Маша!");
}
else // иначе
{
    Console.Write("Привет, ");
    Console.WriteLine(username);
}
