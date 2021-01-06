using System;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            mainmenu mm = new mainmenu();
            mm.main();
        }
    }




    class mainmenu
    {
        System sm = new System();
        account naccount = new account();
        showall nshowall = new showall();
        bool choice = true;
        int userinput = 9;
        public void main()
        {

            do
            {
                Console.WriteLine("\n\nType 1 to create account");
                Console.WriteLine("type 2 to show all account");
                Console.WriteLine("type 0 to terminate console \n\ninput:");
                userinput = Convert.ToInt32(Console.ReadLine());
                if (userinput == 1)
                {
                    naccount.newaccount();

                }
                else if (userinput == 2)
                {
                    nshowall.show();
                }
                else if (userinput == 0)
                {
                    choice = false;
                }
            }
            while (choice != false);
            {
                Console.Write("terminated");
            }

        }

    }
    class showall
    {
        System sm = new System();
        public void show()
        {
            for (int x = 0; x < sm.checker; x++)
            {
                Console.WriteLine(sm.name[x]);
                Console.WriteLine(sm.middleinitial[x]);
                Console.WriteLine(sm.yearlevel[x]);
                Console.WriteLine(sm.course[x]);
            }

        }

    }

    class account
    {
        System sm = new System();

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

            sm.setname(name);
            sm.setmiddleinitial(minitial);
            sm.setyearlevel(yl);
            sm.setcourse(course);
            sm.checkerplusone();


        }
    }

    class System
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
            ;
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
