namespace Costructor
{
    class Program
    {

        static void Main(string[] args)
        {


            //==================================================
            Person p1 = new Person();

            p1.Age = 20;
            p1.FullName = "Reza Karimi";

            p1.Information();

            //==================================================
            //==================================================

            Person p2 = new Person() { Age = 30, FullName = "Mona Ahmadi", };

            p2.Information();

            //==================================================
            //==================================================

            Person p3 =
                new Person()
                {
                    FullName = "Behfar Baghovvat",

                    Age = 36,

                };           

            p3.Information();

            //==================================================
            //==================================================

            Person p4 =
                new Person
                {

                    Age=25,
                    
                    FullName="Zahra Aslani",

                };
            
            p4.Information();

            //==================================================
            //==================================================
            //==The best setting for CONSTRUCTOR is as follows==

            Person p5 = 
                new Person(age:40,fullname:"Kamran Ebadi");

            p5.Information();

            //==================================================
            //==================================================




            System.Console.ReadLine();
        }
    }
}
