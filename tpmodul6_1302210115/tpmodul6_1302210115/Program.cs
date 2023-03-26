// See https://aka.ms/new-console-template for more information
using System;

namespace tpmodul6_1302210115
{
    class Program
    {
        static void Main(string[] args)

        {
            SayaTubeVideo saya = new SayaTubeVideo(" Tutorial Design By Contract - Muhammad Rafkha Prima Aditya ");

            saya.IncreasePlayCount(0);

            saya.PrintVideoDetails();

            Console.WriteLine();

            SayaTubeVideo saya1 = new SayaTubeVideo(" Muhammad Rafkha Prima Aditya");

            saya1.IncreasePlayCount(1000000000);

            saya1.PrintVideoDetails();
        }
    }
}
