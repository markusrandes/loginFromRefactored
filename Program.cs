using System;

namespace Week3
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string Login;
            string Password;
            Console.WriteLine("Login@: ");
            Login = Console.ReadLine();
            Console.WriteLine("Password: ");
            Password = Console.ReadLine();

            if ((Login == "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("Welcome!");
            }
            else if ((Login == "admin") && (Password != "pass1234"))
            {
                Console.WriteLine("The password is incorrect");
            }
            else if ((Login != "admin") && (Password == "pass1234"))
            {
                Console.WriteLine("The login is incorrect.");
            }
            else
            {
                Console.WriteLine("You shall not pass!");
            }

        }
    }
}
