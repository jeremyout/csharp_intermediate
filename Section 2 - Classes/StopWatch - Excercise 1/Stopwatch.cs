using System;
using System.Collections.Generic;

namespace StopWatch___Excercise_1
{
    public class Stopwatch
    {
        private bool _stopwatchIsRunning = false;
        private bool _hasWatchBeenRan = false;
        public DateTime StartTime { get; private set; }
        public DateTime StopTime { get; private set; }
        public TimeSpan Duration { get; private set; }

        public Stopwatch() 
        {
            Duration = TimeSpan.Zero;
        }
        public void Start()
        {
            _hasWatchBeenRan = true;
            if (_stopwatchIsRunning == false)
            {
                _stopwatchIsRunning = true;
                StartTime = DateTime.Now;
                string startMessage =  (Duration == TimeSpan.Zero) ? "\nWatch has started at {0}": "Watch has been re-started at {0}";
                Console.WriteLine(startMessage, StartTime);
            }
            else
            {
                throw new InvalidOperationException("Cannot Start the watch twice, the watch is already running");
            }
        }
        public void Stop()
        {
            if (_stopwatchIsRunning) 
            {
                _stopwatchIsRunning = false;
                StopTime = DateTime.Now;
                Duration += StopTime - StartTime;
                Console.WriteLine("\nWatch was stopped at {0}", StopTime);
                Console.WriteLine("The current duration of this stopwatch is {0}", Duration);
            }
            else
            {
                throw new InvalidOperationException($"Cannot Stop the watch when it is already halted, the current duration of this watch is {Duration}");
            }
        }

        public void Clear()
        {
            if (!_stopwatchIsRunning)
            {
                Duration = TimeSpan.Zero;
                Console.WriteLine("\nThe stopwatch was cleared successfully");
            }
            else
            {
                throw new InvalidOperationException("Please stop the watch to clear");
            }
        }

        public string GetStatusString()
        {
            string status = "";

            if (!_hasWatchBeenRan) 
            {
                status = "The watch has never been started";
            }
            else if (_stopwatchIsRunning)
            {
                TimeSpan currentDuration = DateTime.Now - StartTime;
                status = $"The watch is running and has a current value of {currentDuration.Minutes} minutes, {currentDuration.Seconds} seconds, and {currentDuration.Milliseconds} milliseconds";
            }
            else if (!_stopwatchIsRunning && (Duration != TimeSpan.Zero))
            {
                status = $"The watch is halted and has a current value of {Duration.Minutes} minutes, {Duration.Seconds} seconds, and {Duration.Milliseconds} milliseconds";
            }
            else
            {
                status = $"The watch is halted and has been cleared. Current duration is {Duration}";
            }
            return status;
        }
    }
}
