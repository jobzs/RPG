// See https://aka.ms/new-console-template for more information
using System;
using RPG.src.Entities;

namespace RPG // Note: actual namespace depends on the project name.
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Knight arus = new Knight("Arus", 23, "Knigth");
            Wizard wizard = new Wizard("Jennica", 23, "White Wizard");

            System.Console.WriteLine(arus.Attack());
            System.Console.WriteLine(wizard.Attack());
            System.Console.WriteLine(wizard.Attack(1));
            System.Console.WriteLine(wizard.Attack(7));
            System.Console.WriteLine(wizard);
            System.Console.WriteLine(arus);

        

        }
    }
}