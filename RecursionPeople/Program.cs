using System;
using System.Collections.Generic;

namespace RecursionPeople
{
    class Program
    {
        static void Main(string[] args)
        {

            List<String> people= new List<String>();
            people = Recursivity.Saludar("Raul", "Juan");
            people.ForEach(Console.WriteLine);
        }
    }
}
