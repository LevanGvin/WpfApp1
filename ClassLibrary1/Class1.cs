
namespace ClassLibrary1{
    public static class HelloHelper
    {
        public static string GetGreeting(string username)
        {
            return $"{DateTime.Now:HH:mm:ss} Hello, {username}!";
        }
    }
}