namespace Task_04
{
    public static class Tasks
    {   
        public static void Task1(int a, int b)

        /* The rectangle's sides are a and b. Find its perimeter using the formula: P = 2×(a + b).
         * Find its area following the formula: S = a × b
         * Example: а = 5, b = 3   perimeter = 16
         *          а = 5, b = 3   area = 15
         */

        {
            int perimeter = 2 * (a + b), area = a * b;

            Console.WriteLine($"P = {perimeter}, S = {area}");
        }

        public static void Task2(int a)

        /* The cube`s side is a. Find its volume using the formula: V = a³.
         * Find its surface area following the formula: S = 6 × a²
         * Example: а = 5   volume = 125    surface area = 150
         */

        {
            int volume = a * a * a, surfaceArea = 6 * a * a;

            Console.WriteLine($"V = {volume}, S = {surfaceArea}");
        }

        public static void Task3(int r)

        /* Find the circumference L and the area of a circle S of a given radius 
         * using the formula L = 2 × π × r ,  S = π × R², where π = 3.14.
         * Example: r = 5   circumference = 31.4    area = 78.5
         */

        {
            double pi = 3.14, circumference = 2 * pi * r, area = pi * r * r;

            Console.WriteLine($"L = {Math.Round(circumference, 2)}, S = {Math.Round(area, 2)}");
        }

        public static void Task4(int a, int b, int c)

        /* The cuboid`s edges are a,  b,  c. Find its volume using the formula: V = a × b × c.
         * Find its surface area following the formula: S = 2×(a×b + b×c + a×c).
         * Example: а = 4, b = 2, c = 3   volume = 24   surface area = 52
         */

        {
            int volume = a * b * c, surfaceArea = 2 * (a * b + b * c + a * c);

            Console.WriteLine($"V = {volume}, S = {surfaceArea}");
        }
    }
}
