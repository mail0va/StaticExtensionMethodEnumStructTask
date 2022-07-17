using System;

namespace SEMEShwtask
{
    class Program
    { 
        static void Main(string[] args)
        {
            User user1 = new User("Sema", "Mailova", "1012", User.RegistrationMonth.December);
            User user2 = new User("Irada", "Feyzullayeva", "2122", User.RegistrationMonth.November);
            User user3 = new User("Madina", "Novruzova", "12345", User.RegistrationMonth.March);
            User user4 = new User("ShahNigar", "Kazimova", "qssc5", User.RegistrationMonth.September);
            User user5 = new User("Shefa", "Sadiqova", "sa35", User.RegistrationMonth.January);
            Console.WriteLine(user1.GetDetails());
            Console.WriteLine(user2.GetDetails());
            Console.WriteLine(user3.GetDetails());
            Console.WriteLine(user4.GetDetails());
            Console.WriteLine(user5.GetDetails());

        }
    }
}
