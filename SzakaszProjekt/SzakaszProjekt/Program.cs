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
        /// S3.02 Minden osztálynak van felülírható ToString metódusa, 
        ///       mert minden osztály az Object osztálytól származik.
        ///       A ToString metódus felülírása történik. 
        ///       A kódot az ovverride szó beírásával kezdjük majd gyakorlaton.
        /// </summary>
        /// <returns>A pont osztály adatai string adattípusaba.</returns>
        public override string ToString()
        {
            /// S3.03 A ToString metódus felülírása történik a saját megjelenítési elvárásoknak megfelelően.
            return name + "(" + x + ";" + y + ")";
        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            // S3.04 Két pont példányosítása.
            Point a = new Point('A', 0, 0);
            Point b = new Point('B', 1, 1);
        }
    }
}
