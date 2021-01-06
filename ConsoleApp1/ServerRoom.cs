using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   
        public class Showall
        {
            Server newServer = new Server();
            public void show()
            {
                for (int x = 0; x < newServer.checker; x++)
                {
                    Console.WriteLine(newServer.name[x]);
                    Console.WriteLine(newServer.middleinitial[x]);
                    Console.WriteLine(newServer.yearlevel[x]);
                    Console.WriteLine(newServer.course[x]);
                }
            }
        }

        public class Account
        {
            Student newStudent = new Student();
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

                newServer.setname(name);
                newServer.setmiddleinitial(minitial);
                newServer.setyearlevel(yl);
                newServer.setcourse(course);
                newServer.checkerplusone();
            }
        }

    public class Student
    { 
        public string Name { get; set; }
        public string MiddleInitial{ get; set;}
        public int YearLevel{ get; set;} 
        public string Course { get; set; }
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

