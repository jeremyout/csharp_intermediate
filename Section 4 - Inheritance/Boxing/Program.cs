using System;
using System.Collections;
using System.Collections.Generic;

namespace Boxing
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var list = new ArrayList();
            list.Add(1); // input is an object, so if we send a value type, boxing will happen
            list.Add("Mosh"); // String is a reference type and boxing will nto happen
            list.Add(DateTime.Today); // Struct is a value type so boxing will happen
            // Problems with ArrayList
            // 1. We lose type safety
            var num = (int)list[1]; // exception

            var anotherList = new List<int>();
            anotherList.Add(1); // type safe, no boxing will happen

            var names = new List<string>();
            names.Add("a"); // type safety and no boxing

            // When working with a class if you are calling a method and that method gets an argument of type object. If you pass a value type, boxing will happen and has a performance penalty.
            // Better to use a generic implementation of that class if it exists.
        }
    }
}
