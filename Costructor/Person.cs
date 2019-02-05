namespace Costructor
{

    /// <summary>
    /// Person calss    
    /// </summary>

    class Person
    {        
        public int Age;
        public string FullName;       

        public static int age;
        public static string fullname;

        /// <summary>
        /// Show informatio person.
        /// </summary>

        public void Information()
        {

            string Result = $"Full Name: {FullName} and {Age} years old";
            System.Console.WriteLine(Result);
            System.Console.WriteLine();
        }

        /// <summary>
        ///Default constructor
        /// </summary>

        public Person()
        {
        }

        //-----Constructor overload-----

        /// <summary>
        /// Person class constructor
        /// It is a Constructor whose only field Age and Full Name must be set.
        /// </summary>
        /// <param name="age">Person's Age</param>
        /// <param name="fullname">Person's Full Name</param>

        public Person(int age, string fullname)
        {
            Age = age;
            FullName = fullname;
        }

        /// <summary>
        /// Person class constructor
        /// It is a Constructor whose only field Age must be set.
        /// </summary>
        /// <param name="age">Person's age</param>

        public Person(int age)
        {
            Age = age;

        }

        /// <summary>
        /// Person class constructor
        /// It is a Constructor whose only field Full Name must be set.
        /// </summary>
        /// <param name="fullname">Person's Full Name</param>

        public Person(string fullname)
        {
            FullName = fullname;
        }

        
    }
}
