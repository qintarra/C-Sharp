namespace Task_04
{
    public static class Tasks
    {   
        public static void Task1(int a, int b)

        /* The rectangle's sides are a and b. Find its perimeter using the formula: P = 2×(a + b).
         * Find its area following the formula: S = a × b
         * Example: а = 5, b = 3   perimeter = 16
         *      а = 5, b = 3   area = 15
         */

        {
            int perimeter = 2 * (a + b), area = a * b;

            Console.WriteLine($"P = {perimeter}, S = {area}");
        }


    }
}
