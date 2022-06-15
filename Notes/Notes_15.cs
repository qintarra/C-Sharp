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
