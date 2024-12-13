namespace PersonalRegister
{
    public class ConsoleUI : IConsoleUI
    {

        public void Print(string message)
        {
            Console.WriteLine($"Message: {message}");
        }
        public string GetInput()
        {
            return Console.ReadLine();
        }
    }
}