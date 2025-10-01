using System;
using System.Threading;

namespace ThreadExamples
{
    internal class Program
    {
        static void Main(string[] args)
        {
            RunMenu();
        }

        private static void RunMenu()
        {
            var actions = new Dictionary<int, Action>
            {
                { 1, SleepExample },
                { 2, StartThreadExample },
                { 3, ForegroundBackgroundExample },
                { 4, JoinExample },
                { 5, CurrentThreadInfoExample },
            };

            while (true)
            {
                Console.Clear();
                Console.WriteLine("=== Thread Examples (C#) ===\n");
                Console.WriteLine(" 1) Thread.Sleep (pause current thread)");
                Console.WriteLine(" 2) Create and start a new thread");
                Console.WriteLine(" 3) Foreground vs Background thread");
                Console.WriteLine(" 4) Thread.Join (wait for another thread)");
                Console.WriteLine(" 5) CurrentThread info");
                Console.WriteLine(" 0) Exit");
                Console.Write("\nEnter a number: ");

                int choice = ReadInt("number between 0-5");
                if (choice == 0) break;

                if (actions.TryGetValue(choice, out var action))
                {
                    Console.Clear();
                    action.Invoke();
                }
                else
                {
                    Console.WriteLine("Unknown option. Try again.");
                }

                Console.WriteLine("\nPress any key to return to the menu...");
                Console.ReadKey(true);
            }

            Console.WriteLine("Goodbye!");
        }

        private static int ReadInt(string hint)
        {
            while (true)
            {
                Console.Write($"({hint}) > ");
                string? input = Console.ReadLine();
                if (int.TryParse(input, out int value))
                    return value;

                Console.WriteLine("Invalid number. Try again.");
            }
        }

        // Example 1: Sleep
        static void SleepExample()
        {
            Console.WriteLine("SleepExample: Start waiting...");
            Thread.Sleep(3000); // Pause the current thread for 3000ms (3 seconds)
            Console.WriteLine("SleepExample: Waiting stopped after 3 seconds");
        }

        // Example 2: Create and start a new thread
        static void StartThreadExample()
        {
            Console.WriteLine("StartThreadExample: Creating a new thread...");

            Thread thread = new Thread(() =>
            {
                Console.WriteLine("  Worker thread started.");
                Thread.Sleep(2000); // Simulate some work
                Console.WriteLine("  Worker thread finished.");
            });

            thread.Start(); // Start the new thread
            Console.WriteLine("Main thread continues while worker thread runs.");
        }

        // Example 3: Foreground vs Background threads
        static void ForegroundBackgroundExample()
        {
            Thread backgroundThread = new Thread(() =>
            {
                Console.WriteLine("  Background thread started.");
                Thread.Sleep(5000);
                Console.WriteLine("  Background thread finished.");
            });

            backgroundThread.IsBackground = true; // Mark as background
            backgroundThread.Start();

            Console.WriteLine("ForegroundBackgroundExample: Main thread ends immediately.");
            Console.WriteLine("Because the worker is a BACKGROUND thread, the program will exit before it finishes.");
        }

        // Example 4: Join
        static void JoinExample()
        {
            Thread worker = new Thread(() =>
            {
                Console.WriteLine("  Worker thread started (5s work).");
                Thread.Sleep(5000);
                Console.WriteLine("  Worker thread finished.");
            });

            worker.Start();
            Console.WriteLine("JoinExample: Waiting for worker thread to complete...");
            worker.Join(); // Blocks main thread until worker finishes
            Console.WriteLine("JoinExample: Worker finished, main thread continues.");
        }

        // Example 5: CurrentThread info
        static void CurrentThreadInfoExample()
        {
            Thread current = Thread.CurrentThread;
            Console.WriteLine("CurrentThreadInfoExample:");
            Console.WriteLine($"  Name: {current.Name ?? "(null)"}");
            Console.WriteLine($"  IsBackground: {current.IsBackground}");
            Console.WriteLine($"  ManagedThreadId: {current.ManagedThreadId}");
            Console.WriteLine($"  ThreadState: {current.ThreadState}");
        }
    }
}
