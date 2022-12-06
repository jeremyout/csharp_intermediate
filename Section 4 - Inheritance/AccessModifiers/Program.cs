using Amazon;
using System.Collections.Generic;

namespace AccessModifiers
{
    class Program
    {
        static void Main(string[] args)
        {
            var customer = new Customer();
            //Amazon.RateCalculator calculator= new RateCalculator(); // cannot access because the RateCalculator class is decalred as internal
        }
    }
}
