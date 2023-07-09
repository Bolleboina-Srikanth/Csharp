using System;
using System.Diagnostics;
using System.Reflection;
using System.Text.RegularExpressions;
namespace Object_Oriented
{
    internal class RegularExprection
    {
      /*  public static void Main()
        {
            string[] name = { "mobile number", "email", "user name", "password" };
            for (int i = 0; i < name.Length; i++)
            {
                Console.WriteLine("Press " + i + " to enter " + name[i]);
                int input = int.Parse(Console.ReadLine());
                Console.WriteLine("please enter your data");
                string userCase = Console.ReadLine();
                switch (input)
                {
                    case 0:
                        Regex r = new Regex("^[89][0-9]{9}");
                        bool result = (r.IsMatch(userCase));
                        if (result == true)
                            Console.WriteLine("Your entered " + userCase + ": is a valid number");
                        else
                            Console.WriteLine("enter a valid mobile number");
                        Console.ReadLine();
                        break;
                    case 1:
                        Regex g = new Regex("^[a-z][a-z-A-Z0-9]+@gmail.[a-z]{2,3}$");
                        bool email = (g.IsMatch(userCase));
                        if (email == true)
                            Console.WriteLine("Your entered " + userCase + ": is  valid ");
                        else
                            Console.WriteLine("enter a valid email Id");
                        Console.ReadLine();
                        break;
                    case 2:
                        Regex u = new Regex("^[A-Z]{1}[a-z]{5,15}$");
                        bool userName = (u.IsMatch(userCase));
                        if (userName == true)
                            Console.WriteLine("Your entered " + userCase + ": is  valid ");
                        else
                            Console.WriteLine("enter a valid user name");
                        Console.ReadLine();
                        break;
                    case 3:
                        Regex p = new Regex("^[A-Z]{1}[!@#$%^&*]{1}[a-zA-Z0-9]{6}$");
                        bool password = (p.IsMatch(userCase));
                        if (password == true)
                            Console.WriteLine("Your entered " + userCase + ": is  valid ");
                        else
                            Console.WriteLine("enter a valid password");
                        Console.ReadLine();
                        break;
                }
            }
        }*/
    }
}