using System;

namespace SzakaszProjekt
{
    /// <summary>
    /// Pont osztály.
    /// Geometriai pont két valós koordinátával és egy karakteres névvel.
    /// </summary>
    class Point
    {
        /// <summary>
        /// A pont egy karakteres elnevezése.
        /// </summary>
        private char name;
        /// <summary>
        /// A pont x koordinátája.
        /// </summary>
        private double x;
        /// <summary>
        /// A pont x koordinátája.
        /// </summary>
        private double y;

        /// <summary>
        /// Az osztály minden tulajdonságát megadó konstruktora.
        /// A konstruktornak nincs visszatérési értéke.
        /// </summary>
        /// <param name="name">A pont elnevezése</param>
        /// <param name="x">A pont első koordinátája</param>
        /// <param name="y">A pont második koordinátája</param>
        public Point(char name, double x, double y)
        {
            this.name = name;
            this.x = x;
            this.y = y;
        }

        /// <summary>
        /// S3.01 A ToString metódus az osztály adatait karakterlánccá alakító metódusa.
        /// </summary>
    }

    class Program
    {
        static void Main(string[] args)
        {
        }
    }
}
