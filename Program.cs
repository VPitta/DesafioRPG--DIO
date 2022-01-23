using System;
using DesafioRPG.Entities;
using DesafioRPG.src.Entities;

namespace DesafioRPG
{
    class program
    {
        static void Main(string[] args)
        {
            Knight Arus = new Knight("Arus", 42, "Knight");
            Ninja Wedge = new Ninja("Wedge", 42, "Ninja");
            Wizzard Jenica = new Wizzard("Jenica", 42, "Withe Mage");
            BlackMage Toppa = new BlackMage("Toppa", 42, "Black MAge");

            


            Console.WriteLine(Arus.Attack(101));
            Console.WriteLine();
            Console.WriteLine(Wedge.Attack(11));
            Console.WriteLine();
            Console.WriteLine(Jenica.Attack(7));
            Console.WriteLine();
            Console.WriteLine(Toppa.Attack(31));

        }
     
     }

}