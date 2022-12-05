using System;

namespace Inheritance
{
    partial class Program
    {
        public class Text : PresentationObject // In C#, a class can only have one parent
        {
            public int FontSize { get; set; }
            public string FontName { get; set; }
            public void AddHyperlink(string url)
            {
                Console.WriteLine("We added a link to " + url);
            }
        }
    }
}
