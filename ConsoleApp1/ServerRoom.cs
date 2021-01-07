using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
   
        public class Showall
        {
                    Student newStudent = new Student();
        public void show()
            {
                for (int x = 0; x < 5; x++)
                {
                    Console.WriteLine(newStudent.Name);
                    Console.WriteLine(newStudent.MiddleInitial);
                    Console.WriteLine(newStudent.YearLevel);
                    Console.WriteLine(newStudent.Course);
            }
            }
        }

        public class Account
        {
            Student newStudent = new Student();
            public void newaccount()
            {
                var studentsList = new List<Student>();
                Console.WriteLine("\n\nname:");
                string name = Console.ReadLine();
                Console.WriteLine("middle initial:");
                char minitial = Convert.ToChar(Console.ReadLine());
                Console.WriteLine("year level:");
                int yl = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("course:");
                string course = Console.ReadLine();

                newStudent.Name = name;
                newStudent.MiddleInitial = minitial;
                newStudent.YearLevel = yl;
                newStudent.Course = course;
                studentsList.Add(newStudent);
            }
        }

    public class Student
    {
        

        public string Name { get; set; }
        public char MiddleInitial{ get; set;}
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

