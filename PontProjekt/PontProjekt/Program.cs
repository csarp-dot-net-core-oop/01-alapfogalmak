using System;

namespace PontProjekt
{
    /// <summary>
    /// P1.01 A pont osztály
    /// </summary>
    class Point
    {
        /// <summary>
        /// P1.02 A pont osztály adattagjai (mezők)
        /// A tárolt adatok az objektum pillanatnyi állapotát írják le.
        /// Az adattagokat private elérhetősségel adjuk meg egyenlőre.
        /// Az osztály adattag változóit az osztály elején deklaráljuk.
        /// Ne használjunk aláhúzást a változók nevében.
        /// Az adattagok esetén cameCase névkonvenciót használunk.
        /// Az adattagok nevei leíróak legyenek.
        /// </summary>        
        // P1.03 A pont elnevezése (karakter típus)
        private char name;
        // P1.04 A pont két koordinátája (két egész szám)
        private int x;
        private int y;

        /// <summary>
        /// P1.05 Az osztály konstruktora
        /// Minen objektumnak életciklusa van (megszületik (heap), él, végül "meghal").
        /// Az objektum születésekor meg kell adni a kezdeti adatait (állapotát).
        /// Az osztály inicializásálását végző metódust konstruktornak nevezzük.
        /// A konstruktor neve megegyezik az osztály nevével.
        /// </summary>
        /// <param name="name">A pont elnevezése</param>
        /// <param name="x">A pont első koordinátája</param>
        /// <param name="y">A pont második koordinátája</param>
        public Point(char name, int x, int y)
        {
            // P1.06 A konstruktorban a paraméterben kapott adatokat eltároljuk.
            //      Ezek lesznek a pont objektum kezdetei állapotai.
            // P1.07 A this kulcsszó azonosítja az osztály egy konkrét példányát.
            //      Azért van rá szükség, mert pl. a "name" változónévből kettő van.
            //      Az egyik a paraméterben használt "name" változó, a másik "name" az osztály adattagváltozója.
            this.name = name;
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// P1.10 Egy pont mozgatása keletre
        /// </summary>
        public void MoveEast()
        {
            x = x + 1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            // P1.08 Példányosítás (create instance)
            // Elkészül a pont osztály egy konkrét pont példánya, egy pont objektum.
            // A new operátorral hozzuk létre az osztály egy új példányát.
            // A new operátor után történik a konsturktorhívás (a kezdeti objektum állapottal).
            Point a = new Point('A', 2, -1);
            
            // P1.09 Egy másik pont osztály példányosítása.
            Point b = new Point('B', -2, 3);
        }
    }
}
