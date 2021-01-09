using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp1
{
    public class Server 
        {
            static int limit = 50;
            public static int checker = 0;
            public static string[] name = new string[limit];
            public static char[] middleinitial = new char[limit];
            public static int[] yearlevel = new int[limit];
            public static string[] course = new string[limit];

            public void setname(string newName)
            {
                name[checker] = newName;
            }
            public void setmiddleinitial(char newMiddleinitial)
            {
                middleinitial[checker] = newMiddleinitial;
            }
            public void setyearlevel(int newYearLevel)
            {
                yearlevel[checker] = newYearLevel;
            }
            public void setcourse(string newCourse)
            {
                course[checker] = newCourse;
            }
            public string[] getname()
            {
                return name;
            }
            public char[] getmiddleinitial()
            {
                return middleinitial;
            }
            public int[] getyearlevel()
            {
                return yearlevel;
            }
            public string[] getcourse()
            {
                return course;
            }
            public void setchecker(int newChecker)
            {
               checker = newChecker;
            }
            public int getchecker()
            {
                return checker;
            }
            public void checkerplusone()
            {
                checker++;
            }
        }
    }

