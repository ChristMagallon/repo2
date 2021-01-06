using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   
        class Showall
        {
            Server NewServer = new Server();
            public void show()
            {
                for (int x = 0; x < NewServer.checker; x++)
                {
                    Console.WriteLine(NewServer.name[x]);
                    Console.WriteLine(NewServer.middleinitial[x]);
                    Console.WriteLine(NewServer.yearlevel[x]);
                    Console.WriteLine(NewServer.course[x]);
                }
            }
        }

        public class Account
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

