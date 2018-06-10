using System;
using System.Collections.Generic;

namespace coding
{
    class Program
    {
        // This is my database List.
        static List<Customer> CustomerDB = new List<Customer>();

        public static void LoadDb()
        {
            CustomerDB.Add(new Customer("Jaarana", "Kereopa","123-2514"));
            CustomerDB.Add(new Customer("Sue", "Stook", "123-1263"));
            CustomerDB.Add(new Customer("Jamie", "Allom", "123-3658"));
            CustomerDB.Add(new Customer("Brian", "James", "123-9898"));
            CustomerDB.Add(new Customer("Brian", "Done", "123-36534"));
        }
        static void Main(string[] args)
        {
            LoadDb();

            Console.WriteLine("Search");
            var input = Console.ReadLine();

            foreach(var x in CustomerDB)
            { 
                if(x.GetCustomer().Contains(input))
                {
                    List<string> data = new List<string>();
                    data.Add(x.GetCustomer());
                    Console.WriteLine(string.Join(',', data));
                }
            }
        }
    }
}
