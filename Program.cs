using System;

namespace DatabaseManager.Dapper
{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Server=localhost;Database=rizhwan;User Id=sa;
                                        Password = <YourStrong!Passw0rd>; ";


            var sb = new DatabaseManager(connectionString);

       
            var sss = sb.Query<Customer>("select * from Customer");

            Console.WriteLine("Hello World!");
        }

        class Customer
        {
            public string Name { get; set; }
        }
    }
}