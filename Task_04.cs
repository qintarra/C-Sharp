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
    }
}
