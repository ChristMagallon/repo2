using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            MainMenu NewMainMenu = new MainMenu();
            NewMainMenu.main();
        }
    }

    class MainMenu
    {
        Showall newShowAll = new Showall();
        Account newAccount = new Account();
        bool choice = true;
        int userinput;
        public void main()
        {
            do
            {
                Console.WriteLine("\n\nType 1 to create account");
                Console.WriteLine("type 2 to show all account");
                Console.WriteLine("type 0 to terminate console \n\ninput:");
                userinput = Convert.ToInt32(Console.ReadLine());
               switch(userinput)
                {
                    case 1:
                        newAccount.newaccount();
                        break;
                    case 2:
                        newShowAll.show();
                        break;
                    case 0:
                        choice = false;
                        break;
                    default:
                        Console.WriteLine("Invalid Input");
                        break;  
                }
            }
            while (choice != false);
            {
                Console.Write("terminated");
            }
        }
    }
}

