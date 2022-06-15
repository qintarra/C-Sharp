//14.1
class Person
    {
        public string firstname;
        public string lastname;
        public int age;
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.firstname = "Stanislav";
            p1.lastname = "Lem";
            p1.age = 40;

            Console.WriteLine($"Firstname: {p1.firstname}\nLastname: {p1.lastname}\nAge: {p1.age} years");

            Person p2 = new Person();
            p2.firstname = "Anna";

            Console.WriteLine($"Firstname: {p2.firstname}\nLastname: {p2.lastname}\nAge: {p2.age} years");

            Person[] persons = new Person[3];
            persons[0] = p1;
            persons[1] = p2;

            foreach (Person person in persons)
                if (person != null)
            {
                Console.WriteLine(person.firstname);
            }
        }
    }
	
//14.2
class Person
    {
        private string firstname;
        private string lastname;
        private int age;

        //Method of setting the value of the "firstname" field
        public void SetFirstname (string firstname)
        {
            this.firstname = firstname;
        }

        //Method of getting the value of the "firstname" field
        public string GetFirstName ()
        {
            return firstname;
        }

        public void SetLastname(string surname)
        {
            lastname = surname;
        }

        public string GetLastName ()
        {
            return lastname;
        }

        public void SetAge(int age)
        {
            if (age > 0)
                this.age = age;
            else Console.WriteLine("Wrong age");
        }

        public int GetAge()
        {
            return age;
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.SetFirstname("Stanislaw");
            p1.SetLastname("Lem");
            p1.SetAge(40);

            //We display the name, surname, and age of a person

            Console.WriteLine($"Firstname: {p1.GetFirstName()}\nLastname: {p1.GetLastName()}\nAge: {p1.GetAge()} years");

            //A year has passed...

            //The age of a person has changed
            p1.SetAge(41);
            //Once again, we display the name, surname, and age of a person
            Console.WriteLine($"Firstname: {p1.GetFirstName()}\nLastname: {p1.GetLastName()}\nAge: {p1.GetAge()} years");
        }
    }

//14.3
class Person
    {
        string firstname;
        string lastname;
        int age;

        /* Constructor
         * A constructor is a method whose name is the same as the name of its type
         * Its method signature includes only the method name and its parameter list
         * it doesn't include the return type
         */
        public Person()
        {
            firstname = "Stanislaw";
            lastname = "Lem";
            age = 40;
        }

        //Method for obtaining all information about a person
        public void AboutMe()
        {
            Console.WriteLine($"My name is {firstname} {lastname} and I'm {age} years old");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person();
            p1.AboutMe();

            Person p2 = new Person();
            p2.AboutMe();

            Person p3 = new Person();
            p3.AboutMe();
        }
    }

//14.4
class Person
    {
        string firstname;
        string lastname;
        int age;

        //Constructor with threee parameters
        public Person (string firstname, string lastname, int age)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = age;
        }

        //Constructor to create 27-years old
        public Person(string firstname, string lastname)
        {
            this.firstname = firstname;
            this.lastname = lastname;
            this.age = 27;
        }

        //Parameterless constructor
        public Person()
        {
            firstname = "Isaak";
            lastname = "Azimov";
            age = 70;
        }

        //Method for obtaining all information about a person
        public void AboutMe()
        {
            Console.WriteLine($"My name is {firstname} {lastname} and I'm {age} years old");
        }
    }
    class Program
    {
        static void Main(string[] args)
        {
            Person p1 = new Person("Douglas", "Adams", 42);
            p1.AboutMe();

            Person p2 = new Person("James", "Hendrix");
            p2.AboutMe();

            Person p3 = new Person();
            p3.AboutMe();

            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();
            Console.WriteLine("Enter your lastname");
            string lastname = Console.ReadLine();
            Console.WriteLine("Enter your age");
            int age = int.Parse(Console.ReadLine());
            Person p4 = new Person(name, lastname, age);
            p4.AboutMe();
        }
    }

//14.5
class Person
    {
        string firstName;
        string lastName;

        public Person(string firstName = "Unknown", string lastName = "Unknown")
        {
            this.firstName = firstName;
            this.lastName = lastName;
        }

        public void Info()
        {
            Console.WriteLine($"Firstname: {firstName}\t Lastname: {lastName}");
        }
    }
    class Program
    {
        static void Main (string[] args)
        {
            Person p1 = new Person("Irene", "Adler");
            p1.Info();

            Person p2 = new Person("Anna");
            p2.Info();

            Person p3 = new Person(lastName: "Weber");
            p3.Info();

            Person p4 = new Person();
            p4.Info();
        }
    }