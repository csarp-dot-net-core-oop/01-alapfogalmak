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
        /// S3.09 Elkészítjük az pont x és y adattagokjaihoz kapcsolodó tulajdonságokat.
        ///       A pont koordinátáit csak leolvasni lehet (get), módosítani nem.
        /// </summary>
        public double X { get => x; }
        public double Y { get => y; }

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
 
    /// <summary>
    /// S3.06 Szakasz osztály.
    ///       Geometriai szakasz két megadott ponttal.
    /// </summary>
    class LineSegment
    {
        /// <summary>
        /// S3.06 A szakasz kezdőpontja (adattag vagy más néven mező, angolul class member).
        /// </summary>
        private Point startPoint;
        /// <summary>
        /// S3.06 A szakasz végpontja;
        /// </summary>
        private Point endPoint;

        /// <summary>
        /// S3.06 A szakasz osztály konstruktora.
        /// A konstruktornak nincs visszatérési értéke.
        /// </summary>
        /// <param name="startPoint"></param>
        /// <param name="endPoint"></param>
        public LineSegment(Point startPoint, Point endPoint)
        {
            this.startPoint = startPoint;
            this.endPoint = endPoint;
        }

        /// <summary>
        /// S3.08 Szakasz hossz tulajdonság (property).
        /// A tulajdonság egy speciális adattag, mely segítségével a private hatókörű változók elérését szabályozhatjuk.
        /// Olyanok mint egy public hatókörű változók, de rendekeznek get és set metódusokkal.
        /// PascalCase konvenciót követünk tulajdonságok írásakor.
        /// </summary>
        public double Length
        {
            // S3.08 A get metóus megadja a Length tulajdonság értékét.
            //       A hossz kiszámításához szükség van a pontok x és y koordinátájára.
            //       https://www.mathreference.org/index/page/id/79/lg/hu
            //       A szakasz pontjainak koordinátái egyenlőre nem érthetők el a szakasz osztályban.
            get
            {
                // S3.10 A képletnek megfelelően kiszámoljuk a szakasz hosszát és ez lesz a get metódus visszatérési értéke.
                double length = Math.Sqrt(Math.Pow(endPoint.X - startPoint.X, 2) + Math.Pow(endPoint.Y - startPoint.Y, 2));
                return length;
            }
        }

        /// <summary>
        /// S3.11 Szakasz felezőpont tulajdonság.
        ///       https://tudasbazis.sulinet.hu/hu/matematika/matematika/matematika-11-osztaly/szakasz-hossza-felezopontja/szakasz-felezopontja
        /// </summary>
        public Point MidPoint
        {
            get
            {
                double midPointX = (startPoint.X + endPoint.X) / 2;
                double midPointY = (startPoint.Y + endPoint.Y) / 2;
                Point midPoint = new Point('F', midPointX, midPointY);
                return midPoint;
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            // S3.04 Két pont példányosítása.
            Point a = new Point('A', 0, 0);
            Point b = new Point('B', 1, 1);

            // S3.05 A példányosított pontok megjelenítése a felülírt metódus segítségével.
            Console.WriteLine(a.ToString());
            Console.WriteLine(b);

            // S3.07 Szakaszt készítünk az a, és b pontokból.
            //       Célkitűzés: szakasz hossz, és felezőpont koordinátájának meghatározása.
            LineSegment s = new LineSegment(a, b);

        }
    }
}
