    //15.1
    class Person
    {
        string firstname;
        string lastname;
        int age;

        public Person(string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public string LastName //Property
        {
            get
            {
                return lastname; //Returns the value of a field
            }
            set
            {
                lastname = value; //Sets the value of a field
            }
        }
        public string FirstName //Property
        {
            get
            {
                return firstname; //Returns the value of a field
            }
            set
            {
                if (value.Length > 1)
                    firstname = value; //Sets the value of a field
                else Console.WriteLine("Name is too short");
            }
        }
        public int Age //Property
        {
            get
            {
                return age; //Returns the value of a field
            }
            set
            {
                if (value > 0)
                    age = value; //Sets the value of a field
                else age = 18;
            }
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Person p = new Person("Willard", "Smith", 55);

            Console.WriteLine($"Name: {p.FirstName}\t Age: {p.Age}");

            p.Age = 56;
            Console.WriteLine($"Name: {p.FirstName}\t Age: {p.Age}");

            p.FirstName = "Will";
            Console.WriteLine($"New name: {p.FirstName}");
        }
    }
	
    //15.2
    class Person
    {
        public string Name { get; private set; }
        public int Age { get; set; }
        public Person()
        {
            Name = "Helena";
            Age = 20;
        }
    }

    //Auto-property
    class NewPerson
    {
        public string Name { get; } = "Edward";
        public int Age { get; set; } = 22;
    }

    class Program
    {
        static void Main (string [] args)
        {
            Person p1 = new Person();
            Console.WriteLine($"Name: {p1.Name}\t Age: {p1.Age}");
            p1.Age = 21;
            Console.WriteLine($"Name: {p1.Name}\t Age: {p1.Age}");

            NewPerson p2 = new NewPerson();
            Console.WriteLine($"Name: {p2.Name}\t Age: {p2.Age}");
            p2.Age = 25;
            Console.WriteLine($"Name: {p2.Name}\t Age: {p2.Age}");
        }
    }
	
    //15.3
    class Person
    {
        private readonly string firstname;
        private readonly string lastname;
        private readonly int age;

        public Person (string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        public void SetFirstName(string firstname)
        {
            //this.firstname = firstname;
        }
    }
	
    //15.4
    struct Point
    {
        public double x, y;
        public void PointInfo()
        {
            Console.WriteLine($"Point coordinates: x={x} y={y}");
        }
        public void MoveTo (double x1, double y1)
        {
            x = x1;
            y = y1;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Point p1;
            p1.x = 1;
            p1.y = 6;
            p1.PointInfo();

            Point p2;
            p2.x = 4;
            p2.y = 10;
            Console.WriteLine($"Second point coordinates x={p2.x} y={p2.y}");

            double d = Math.Sqrt(Math.Pow(p1.x - p2.x, 2) + Math.Pow(p1.y - p2.y, 2));
            Console.WriteLine($"The distance between the points is {d}");

            p1.MoveTo(5, 4);
            p1.PointInfo();
        }
    }
	
    //15.5
    //Struct vs Class
    class MyClass
    {
        public int x;
    }

    struct MyStruct
    {
        public int x;
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Create a billion instances of the structure");
            DateTime start = DateTime.Now;
            for (int i = 0; i < 1000000000; i++)
            {
                MyStruct m;
                m.x = 10;
                int q = m.x;
            }
            DateTime finish = DateTime.Now;
            long x = finish.Ticks - start.Ticks;
            Console.WriteLine("OK");
            Console.WriteLine(x);
            Console.WriteLine(DateTime.FromBinary(x).ToLongTimeString());

            Console.WriteLine("Create a billion instances of the structure");
            start = DateTime.Now;
            for (int i = 0; i < 1000000000; i++)
            {
                MyClass m = new MyClass();
                m.x = 10;
                int q = m.x;
            }
            finish = DateTime.Now;
            x = finish.Ticks - start.Ticks;
            Console.WriteLine("OK");
            Console.WriteLine(x); Console.WriteLine(DateTime.FromBinary(x).ToLongTimeString());
        }
    }
