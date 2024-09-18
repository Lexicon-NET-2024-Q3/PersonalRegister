namespace PersonalRegister
{
    public class ConsoleUI
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