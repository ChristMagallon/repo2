using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            mainMenu();
        }

        static void mainMenu()
        {
            bool choice = true;
            int userinput;

            do
            {
                Console.WriteLine("\n\nType 1 to create account");
                Console.WriteLine("type 2 to show all account");
                Console.WriteLine("type 0 to terminate console \n\ninput:");
                userinput = Convert.ToInt32(Console.ReadLine());
                switch (userinput)
                {
                    case 1:
                        NewAccount();
                        break;
                    case 2:
                        Showall();
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


        static void NewAccount()
        {
            Server newServer = new Server();

            Console.WriteLine("\n\nname:");
            string name = Console.ReadLine();
            Console.WriteLine("middle initial:");
            char minitial = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("year level:");
            int yl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("course:");
            string course = Console.ReadLine();

            newServer.setname(name);
            newServer.setmiddleinitial(minitial);
            newServer.setyearlevel(yl);
            newServer.setcourse(course);
            newServer.checkerplusone();
        }
        static void Showall()
        {
            for (int x = 0; x < Server.checker; x++)
            {
                Console.WriteLine("\n\n############");
                Console.WriteLine("name: " + Server.name[x]);
                Console.WriteLine("name: " + Server.middleinitial[x]);
                Console.WriteLine("name: " + Server.yearlevel[x]);
                Console.WriteLine("name: " + Server.course[x]);
            }
        }
    }
}





