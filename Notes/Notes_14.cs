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
