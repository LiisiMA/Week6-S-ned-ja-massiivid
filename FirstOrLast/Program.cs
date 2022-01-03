using System;

namespace FirstOrLast
{
    class Program
    {
        static void Main(string[] args)
        {
            //programm küsib kasutajal sisestada ees- ja perekonnanime
            //programm kontrollib andmete pikkust
            //programm kuvab kumb nendest on pikem, kas ees- või perekonnanimi

            Console.WriteLine("Sisesta oma eesnimi:");
            string firstName = Console.ReadLine();
            Console.WriteLine("Sisesta oma perenimi:");
            string lastname = Console.ReadLine();

            if (firstName.Length > lastname.Length)
            {
                Console.WriteLine(firstName);
            } else if (firstName.Length == lastname.Length) { Console.WriteLine("Võrdne " + firstName + " " + lastname); } 
            else Console.WriteLine(lastname);
        }
    }
}
