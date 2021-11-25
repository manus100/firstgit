using System;
using System.Diagnostics;
using System.Text;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World Manuela! Modificare noua!!!");

            string mystring = "Hello";
            string myNextString = "World";

            string a = "a";
            string b = "b";
            string c = "c";
            string random = "B";


            int resultLeft = string.Compare(a, b);
            int resultRight = string.Compare(c, b);
            int resultEqual = string.Compare(random, b,true);  //true = ignore case

            //Concatenari
            mystring = mystring + "World";

            string hellorWordls = mystring + " " +  myNextString;

            Stopwatch stopWatch = new Stopwatch();     //StopWatch.StartNew()

            stopWatch.Start();
            for (int i = 0; i < 100000; i++)
            {
                mystring += i;  //imi creeaza cate un string nou de fiecare data
            }

            stopWatch.Stop();
            Console.WriteLine(stopWatch.ElapsedMilliseconds);
            Console.WriteLine("For String " + stopWatch.Elapsed);

            //stringbuilder - lucreaza eficient cu stringurile nu creeaza unul nou de fiecare data, ci se expandeaza zona de memorie

            StringBuilder builder = new StringBuilder();
            Stopwatch stopWatch1 =   new Stopwatch();     //Stopwatch stopWatch1 = StopWatch.StartNew()  -- de vazut de ce nu merge asa 

            stopWatch1.Start();
            builder.Append(mystring);
            for (int i = 0; i < 100000; i++)
            {
                builder.Append(i);   //adauga la coada
            }
            stopWatch1.Stop();
            Console.WriteLine(stopWatch1.ElapsedMilliseconds);
            Console.WriteLine("For StringBuilder " + stopWatch1.Elapsed);

            

        }
    }
}
