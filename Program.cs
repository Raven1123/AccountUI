using AccountBusinessService;
using System;
namespace AccountUI
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter your username: ");
            string Username = Console.ReadLine();

            Console.WriteLine("Enter password: ");
            string Password = Console.ReadLine();

            UserAccountServices userAccountService = new UserAccountServices();
            bool result = userAccountService.VerifyUser(Username);

            if (result)
            {
                Console.WriteLine("Welcome to UI User Account!");
            }
            else
            {
                Console.WriteLine("ERROR.");
            }
        }
    }
}
