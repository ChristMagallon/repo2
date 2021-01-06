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
        Account newAccount = new Account();
        Showall newShowall = new Showall();
        bool choice = true;
        int userinput;
        public void main()
        {
            do
            {
                Console.WriteLine("Testttinggggg 123");
                Console.WriteLine("Testttinggggg 123");
                Console.WriteLine("Testttinggggg 123");
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
                        newShowall.show();
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
    class Showall
    {
        Server NewServerRoom = new Server();
        public void show()
        {
            for (int x = 0; x < NewServerRoom.checker; x++)
            {
                Console.WriteLine(NewServerRoom.name[x]);
                Console.WriteLine(NewServerRoom.middleinitial[x]);
                Console.WriteLine(NewServerRoom.yearlevel[x]);
                Console.WriteLine(NewServerRoom.course[x]);
            }
        }
    }

    class Account
    {
        Server NewServer = new Server();
        public void newaccount()
        {
            Console.WriteLine("\n\nname:");
            string name = Console.ReadLine();
            Console.WriteLine("middle initial:");
            char minitial = Convert.ToChar(Console.ReadLine());
            Console.WriteLine("year level:");
            int yl = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("course:");
            string course = Console.ReadLine();

            NewServer.setname(name);
            NewServer.setmiddleinitial(minitial);
            NewServer.setyearlevel(yl);
            NewServer.setcourse(course);
            NewServer.checkerplusone();
        }
    }

    class Server
    {
        static int limit = 50;
        public int checker = 0;
        public string[] name = new string[limit];
        public char[] middleinitial = new char[limit];
        public int[] yearlevel = new int[limit];
        public string[] course = new string[limit];

        public void setname(string name)
        {
            this.name[checker] = name;
        }
        public void setmiddleinitial(char middleinitial)
        {
            this.middleinitial[checker] = middleinitial;     
        }
        public void setyearlevel(int yearlevel)
        {
            this.yearlevel[checker] = yearlevel;
        }
        public void setcourse(string course)
        {
            this.course[checker] = course;
        }
        public string[] getname()
        {
            return this.name;
        }
        public char[] getmiddleinitial()
        {
            return this.middleinitial;
        }
        public int[] getyearlevel()
        {
            return this.yearlevel;
        }
        public string[] getcourse()
        {
            return this.course;
        }
        public void setchecker(int checker)
        {
            this.checker = checker;
        }
        public int getchecker()
        {
            return this.checker;
        }
        public void checkerplusone()
        {
            checker++;
        }
    }
}
