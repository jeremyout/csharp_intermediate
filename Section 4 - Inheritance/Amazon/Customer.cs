using System;

namespace Amazon
{
    public class Customer
    {
        public int Id { get; set; }
        public string Name { get; set; }

        public void Promote()
        {
            var calculator = new RateCalculator(); // Not a good idea to instantiate this inside a method like this. This creates coupling.
            var rating = calculator.Calculate(this);
            Console.WriteLine("Promote logic changed");
        }
    }
}
