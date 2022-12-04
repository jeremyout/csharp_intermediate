using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace StopWatch___Excercise_1
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Welcome to my stopwatch\n");
            Console.WriteLine("Here is your key for operations");
            Console.WriteLine("\tEnter \"Start\" to start the watch when the watch is not running");
            Console.WriteLine("\tEnter \"Stop\" to stop the watch when the watch is running");
            Console.WriteLine("\tEnter \"Clear\" to reset the stopwatch back to zero when the watch is stopped");
            Console.WriteLine("\tEnter \"Quit\" to stop running the application");
            Console.WriteLine("\tEnter \"Status\" to get a current status of the stopwatch\n");

            var stopwatch = new Stopwatch();

            string command = null;
            do
            {
                try
                {
                    Console.WriteLine("\nPlease enter a command:");
                    command = Console.ReadLine().ToLower();

                    switch (command)
                    {
                        case "start":
                            {
                                stopwatch.Start();
                                break;
                            }
                        case "stop":
                            {
                                stopwatch.Stop();
                                break;
                            }
                        case "clear":
                            {
                                stopwatch.Clear();
                                break;
                            }
                        case "quit":
                            {
                                Console.WriteLine("\nProgram exiting...");
                                break;
                            }
                        case "status":
                            {
                                Console.WriteLine($"\nThe current status of the watch is:\n\t{stopwatch.GetStatusString()}");
                                break;
                            }
                        default:
                            {
                                Console.WriteLine("\nPlease enter one of the following options: \"Start\", \"Stop\", \"Clear\", \"Status\", or \"Quit\".");
                                break;
                            }
                    }

                }
                catch (Exception ex)
                {
                    Console.WriteLine("Something went wrong: {0}", ex.Message);
                    Console.WriteLine("Please select a command from the options listed above");
                }
            } while (command != "quit");
        }
    }
}
