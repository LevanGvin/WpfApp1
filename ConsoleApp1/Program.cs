using ClassLibrary1;

class ConsoleVers
{
    static void Main(string[] args)
    {
        string username;

        if (args.Length > 0)
        {
            username = args[0];
        }
        else
        {
            username = "User";
        }

        string message = HelloHelper.GetGreeting(username);
        Console.WriteLine(message);
    }
}