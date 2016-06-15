using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WEEK1DAY3
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Commented out Code
            //int len = 5;
            //string[] singleArray = new string[len];
            //string[,] multiArray = new string[5,5];

            //for (int i = 0; i < singleArray.Length; i++)
            //{
            //    singleArray[i] = string.Format("Something{0}", i);
            //}

            //for (int i = 0; i < singleArray.Length; i++)
            //{
            //    Console.WriteLine(singleArray[i]);
            //}

            //for(int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j<5; j++)
            //    {
            //        multiArray[i, j] = string.Format("multi{0}-{1} ", i, j);
            //    }
            //}

            //Console.WriteLine();

            //for (int i = 0; i < 5; i++)
            //{
            //    for (int j = 0; j < 5; j++)
            //    {
            //        Console.Write(multiArray[i, j]);
            //    }
            //    Console.WriteLine();
            //}
            //Console.WriteLine();

            List<string> stringList = new List<string>();

            List<List<string>> nestedList = new List<List<string>>();

            stringList.Add("New thing");

            for (int i = 0; i < 10; i++)
            {
                stringList.Add(string.Format("stuff {0}", i));
            }

            for (int i = 0; i < 10; i++)
            {
                stringList.Add(string.Format("moreStuff {0}", i));
            }

            foreach (string temp in stringList)
            {
                Console.WriteLine(temp);
            }

            Console.WriteLine();

            if (stringList.Contains("moreStuff 2"))
                Console.WriteLine("I found it");

            if ("moreStuff".ToUpper() == "MoreStuff".ToUpper())
                Console.WriteLine("they are the same");

            Console.WriteLine("MoreStuff".ToUpper());
            Console.WriteLine("MoreStuff".ToLower());

            #endregion

            #region Second Region

            #endregion

            //string returnThing = WriteToTheConsole("Print this");
            //string returnThing2 = WriteToTheConsole("print this");
            //int int1 = 0, int2 = 0;

            //int newNum = AddFive(ref int1, ref int2, 5);

            //WriteToTheConsole(int1.ToString());
            //WriteToTheConsole(int2.ToString());

            Console.ReadKey();

            NewMethod("test");
        }

        /// <summary>
        /// This method returns true if something happens
        /// </summary>
        /// <param name="temp"></param>
        /// <returns>bool</returns>
        static bool NewMethod(string temp)
        {
            return true;
        }

        static void WriteToTheConsole(string someString)
        {
            Console.WriteLine(someString);
        }

        static int AddFive(ref int someInt, ref int someInt2, int someNum)
        {
            someInt = someNum * 2;
            someInt2 = someNum * 3;

            return someInt2;
        }
    }
}
