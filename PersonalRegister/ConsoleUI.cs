namespace PersonalRegister
{
    public class ConsoleUI
    {

        public void Print(string message)
        {
            Console.WriteLine(message);
        }
        public string GetInput()
        {
            return Console.ReadLine(); 
        }
    }
}