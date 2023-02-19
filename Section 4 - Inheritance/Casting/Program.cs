using System;
using System.Collections;
using System.Collections.Generic;
using System.IO;

namespace Casting
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Upcasting:
            //Text text = new Text();
            //Shape shape = text;

            //text.Width = 200;
            //shape.Width = 100;

            //Console.WriteLine(text.Width); //output is 100 because text and shape are both references to the same object, they just have different views

            //Where would we use this in a real world scenario?
            //StreamReader reader = new StreamReader(new MemoryStream());
            // Both FileStream and MemoryStream derive from the Stream class

            //ArrayList list = new ArrayList();
            //list.Add(1);
            //list.Add("Mosh");
            //list.Add(new Text());
            //// ArrayList is not type-safe, better way is to use generic lists

            //var anotherList = new List<int>(); // every element in the list will be an int
            //var anotherList2 = new List<Shape>(); // every element in the list will be a Shape

            // Downcasting:
            Shape shape = new Text();
            //shape. -- Don't have access to properties defined in the Text object
            Text text = (Text)shape;
            //text. -- Have access to every property in the Text class
        }
    }
}
