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

    /// O1.09 1. feladat
    /// Készítsen megjegyzést a Pig osztályhoz!
    /// Készítsen megjegyzést a Say metódushoz! 
    ///  Az osztánynál három "/"-el lehet elkészíteni. Majd beírni a  </summary> taget záróteggel.
    ///  Ez azért van, mert már van megjegyzés az osztály előtt.
    ///  A metódus előtt egy üres sorban csak írja be a három "/" jelet és a megjegyzés törzse elkészül, a szöveg utána beírható.
    class Pig
    {
        public void Say()
        {
            Console.WriteLine("The pig says: wee wee.");
        }
    }


        class Program
    {
        static void Main(string[] args)
        {
            // O1.05 OOP programozás
            // Az OOP programozás során a programokat objektumokból építjük fel.
            //  - Minden objektumnak megvan a jól meghatározott feladata.
            //  - Az objektumok képesek egymással kommunikálni.
            //  - OOP programozás során a programozást közelítjük az emberi gondolkodáshoz.

            // O1.06 Példányosítás
            // Cat osztály példányosítása (create instance of class).
            //  - A myCat objektum a Cat osztály egy példánya.
            //  - A lokális változókat írásakor a caneCaseing jelölést használunk.
            Cat myCat = new Cat();

            // O1.07 Példányosított objektum viselkedik (beszél)
            // A myCat objektum képes "beszélni". Az eredményt most a konzolon olvashatjuk.            
            myCat.Say();

            // O1.08 Kódújrafelhasználás
            // A Dog osztályból két példányt készítünk. 
            // Ezt nevezzük kód újrafelhasználásnak. A kódot csak egyszer írtuk meg, az osztályban
            // és most két példány (myDogBenji és myDogGizmo) is ugyan azt a kódot hajtja végre.
            Dog myDogBenji = new Dog();
            myDogBenji.Say();
            Dog myDogGizmo = new Dog();
            myDogGizmo.Say();
        }
    }
}
