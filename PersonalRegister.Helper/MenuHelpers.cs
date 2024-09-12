using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalRegister.Helpers
{
    public static class MenuHelpers
    {
        public const string Add = "1";
        public const string Print = "2";
        public const string Quit = "Q";
        public static void ShowMainMenu()
        {
            Console.WriteLine($"{Add}: Add employee" +
                   $"\n{Print}: Show employees" +
                   $"\n{Quit}: Quit");
        }

    }
}
