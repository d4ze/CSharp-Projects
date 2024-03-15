Console.Write("Username:");
string username = Console.ReadLine();
Console.Write("Password:");
string password = Console.ReadLine();


if (username == "admin" && password == "1234")
{
    Console.WriteLine("Login is successful");
}
else
{
    Console.WriteLine("Wrong username or password");
}
