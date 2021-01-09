using System;

namespace Bevezeto
{
    /// <summary>
    /// O1.01 Cat(macska) osztály
    /// Az osztály egy kiterjesztett adat típus. Az osztály egy program kód sablon, amelyben 
    /// állapotokat (adatokat) és viselkedési mintákat, műveleteket (metódusokat) lehet definiálni.
    /// Az osztályok neveit nagybetűvel (PascalCase) írjuk.
    /// Használjunk főneveket az osztály nevének megadásakor.
    /// </summary>
    class Cat
    {
        /// <summary>
        /// O1.02 Cat osztály metódusa
        /// A metódus valamilyen tevékenységet ír le, azaz algoritmust valósít meg.            
        /// A metódus nevét nagy betűvel (PascalCase) írjuk.
        /// Nem használunk a metódus nevénél rövidítést
        /// A metódus nevét igével kezdjük.
        /// </summary>
        public void Say()
        {
            Console.WriteLine("The cat says: meow meow");
        }
    }
    /// <summary>
    /// O1.3 Dog (kutya) osztály
    /// </summary>
    class Dog
    {
        /// <summary>
        /// O1.04 Polimorfizmus (többalakúság)
        ///  - Egyazon objektum többfélének látszódhat.
        ///  - Több különböző fajta objektum ugyanolyannak látszódhat.
        ///  Itt a második esetről van szó. Mindegyik osztály (Cat, Dog...) ugyan úgy,
        ///  a beszél művelettel "beszél", de mindegyik különböző dolgokat mond.
        /// </summary>
        public void Say()
        {
            Console.WriteLine("The dog says: bow wow");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
