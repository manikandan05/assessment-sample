using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.ExceptionServices;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {

            //first program

            string data = Console.ReadLine();
            string newData = "";
            if (data.Length > 0)
            {
                for (var i = 0; i < data.Length; i++)
                {
                    if (!(data[i] == 'a' || data[i] == 'e' || data[i] == 'i' || data[i] == 'o' || data[i] == 'u'))
                    {
                        newData += data[i];
                    }
                }
            }
            Console.WriteLine(newData);


            //second program

            string newArrayData = Console.ReadLine();

            string[] newList = newArrayData.Split(",");
            int count = newList.Length;
            int higherbound = Int16.MinValue;
            int lowerbound = Int16.MaxValue;
            if (count > 0)
            {
                for (var j = 0; j < count; j++)
                {
                    if (Int16.Parse(newList[j]) > higherbound)
                    {
                        higherbound = Int16.Parse(newList[j]);
                    }
                }
                for (var j = 0; j < count; j++)
                {
                    if (Int16.Parse(newList[j]) < lowerbound)
                    {
                        lowerbound = Int16.Parse(newList[j]);
                    }
                }
            }
            Console.WriteLine("UpperBound" + higherbound);
            Console.WriteLine("LowerBound" + lowerbound);


            //Third program
            string[] arrList = data.Split("");
            List<string> compareList = new List<string>();
            List<string> shortList = new List<string>();
            if (arrList.Length > 0)
            {
                for (var k = 0; k < arrList.Length; k++)
                {
                    if (compareList.Count == 0 || compareList[0].IndexOf(arrList[k]) == -1)
                    {
                        compareList.Add(arrList[k]);
                    }
                    else
                    {
                        compareList.Add(arrList[k]);
                        shortList = compareList;
                        compareList = new List<string>();
                    }
                }
            }
        }
    }
}
