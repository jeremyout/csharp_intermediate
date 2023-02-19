using System;

namespace AbstractClasses
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var shape = new Shape(); // Cannot do this because it is abstract

            var circle = new Circle();
            circle.Draw();

            var rectangle = new Rectangle();
            rectangle.Draw();
        }
    }
}
