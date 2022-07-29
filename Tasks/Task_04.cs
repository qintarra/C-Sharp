namespace Task_04
{
    public static class Tasks
    {   
        /* The rectangle's sides are a and b. Find its perimeter using the formula: P = 2×(a + b).
        Find its area following the formula: S = a × b
        Example: а = 5, b = 3,	 perimeter = 16,	 area = 15 */      
        public static void Task1(int a, int b)
        {
            int perimeter = 2 * (a + b), area = a * b;

            Console.WriteLine($"P = {perimeter}, S = {area}");
        }

        /* The cube`s side is a. Find its volume using the formula: V = a³.
        Find its surface area following the formula: S = 6 × a²
        Example: а = 5,   volume = 125,    surface area = 150 */    
        public static void Task2(int a)
        {
            int volume = a * a * a, surfaceArea = 6 * a * a;

            Console.WriteLine($"V = {volume}, S = {surfaceArea}");
        }
		
        /* Find the circumference L and the area of a circle S of a given radius 
        using the formula L = 2 × π × r ,  S = π × R², where π = 3.14.
        Example: r = 5,   circumference = 31.4,    area = 78.5 */       
        public static void Task3(int r)
        {
            double pi = 3.14, circumference = 2 * pi * r, area = pi * r * r;

            Console.WriteLine($"L = {Math.Round(circumference, 2)}, S = {Math.Round(area, 2)}");
        }
		
        /* The cuboid`s edges are a,  b,  c. Find its volume using the formula: V = a × b × c.
        Find its surface area following the formula: S = 2×(a×b + b×c + a×c).
        Example: а = 4, b = 2, c = 3, 	volume = 24, 	surface area = 52 */ 
        public static void Task4(int a, int b, int c)
        {
            int volume = a * b * c, surfaceArea = 2 * (a * b + b * c + a * c);

            Console.WriteLine($"V = {volume}, S = {surfaceArea}");
        }
		
        /* The speed of the boat in the stagnant water is V km/h, and the speed of the river's flow is U km/h (U < V). 
        The boat's moving time in the lake is T1 h and in the river (against the flow) is T2 h. 
        Find the distance, that was passed by a boat (distance = speed * time). 
        Take into consideration that when the boat is moving against the flow, the boat`s speed decreases with the speed of flow.
        Example: V = 20 km/h; U = 5 km/h; T1 = 2 h; T2 = 3 h  =>  Distance = 85 km 
                 V = 18.7 km/h; U = 3.2 km/h; T1 = 0.5 h; T2 = 1.25 h  =>  Distance = 28.73 km 
                 V = 22 km/h; U = 7.3 km/h; T1 = 2 h; T2 = 1.5 h  =>  Distance = 66.05 km */      
        public static void Task5(double v, double u, double t1, double t2)
        {
            double distance = v * t1 + (v - u) * t2;

            Console.WriteLine(Math.Round(distance, 2));
        }

        /* The speed of the first car is V1 km/h, the speed of the second car is V2 km/h, and the distance between them is S km. 
        Find the distance between cars after T hours, if the cars are distancing from each other. 
        The given distance is equal to the sum of the initial distance + the general way, which was covered by cars; the general way = time*total speed.
        Example: V1 = 90 km/h; V2 = 110 km/h; S = 65 km; T = 3 h  =>  Distance = 665 km 
                 V1 = 65.5 km/h; V2 = 90.4 km/h; S = 20.9 km; T = 1.5 h  =>  Distance = 254.75 km 
                 V1 = 70 km/h; V2 = 85.6 km/h; S = 32.6 km; T = 2 h  =>  Distance = 343.8 km */        
        public static void Task6(double s, double t, double v1, double v2)
        {
            double distance = v1 * t + v2 * t + s;

            Console.WriteLine(Math.Round(distance, 2));
        }
    }
}
