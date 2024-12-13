namespace PersonalRegister
{
    public class ConsoleUI : IUI
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

    public class MockUI : IUI
    {
        public string SetInput { private get; set; } = "1";
        public void Print(string message)
        {
            
        }
        public string GetInput()
        {
            return SetInput;
        }
    }
}