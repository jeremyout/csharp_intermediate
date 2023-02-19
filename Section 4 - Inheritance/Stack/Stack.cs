using System;
using System.Collections;
using System.Collections.Generic;
using System.Runtime.InteropServices;

namespace Stack
{
    public class Stack
    {
        private ArrayList MyStack = new ArrayList();
        public void Push(object obj) 
        {
            try
            {
                if (obj == null) throw new InvalidOperationException("Cannot add null to the stack");

                MyStack.Add(obj);
            }
            catch (InvalidOperationException ex)
            {
                // handle the InvalidOperationException
                Console.WriteLine("An InvalidOperationException occurred: " + ex.Message);
            }


        }
        public object Pop() 
        {
            try
            {
                if (MyStack.Count == 0) throw new InvalidOperationException("Stack is Empty, nothing to Pop!");
                
                var popped = MyStack[MyStack.Count - 1];
                MyStack.RemoveAt(MyStack.Count - 1);
                return popped;
            }
            catch (InvalidOperationException ex) 
            {
                // handle the InvalidOperationException
                Console.WriteLine("An InvalidOperationException occurred: " + ex.Message);
                return null;
            }

            

            
        }
        public void Clear() 
        {
            MyStack.Clear();
        }
    }
}
