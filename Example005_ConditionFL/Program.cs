Console.Write("Введите имя пользователя ");
string username = Console.ReadLine();

if(username.ToLower() == "алисочка" )
{
    Console.WriteLine("Ура Алисочка, я вас ЛЮБЛЮ!");
}
else
{
    Console.Write("Привет,");
    Console.WriteLine(username);
}
