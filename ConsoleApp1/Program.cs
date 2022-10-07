using System;
using Course.Entites;
    

namespace Course
{
    class Program
    {
        static void Main(string[] args)
        {
            BusinessAccount account = new(0446, "Vinicius Sato", 1000.0, 500);

            Console.WriteLine(account.Balance);
            
        }
    }
}
