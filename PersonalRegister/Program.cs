using System.ComponentModel;
using PersonalRegister.Helpers;

namespace PersonalRegister
{
    internal class Program
    {
       
        static void Main(string[] args)
        {
            Main main = new Main();
            try
            {
            //Employee emp = new Employee(null, 25);
            main.Run();

            }
            catch (ArgumentNullException ex)
            {
                Console.WriteLine(ex.Message);                
                //throw;
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
                //throw;
            }
            finally
            {
                main.Run(); 
            }
        }     

       
    }
}
