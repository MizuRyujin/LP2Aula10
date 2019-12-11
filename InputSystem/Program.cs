using System;
using System.Threading;
using System.Collections.Concurrent;

namespace InputSystem
{
    class Program
    {
        private static BlockingCollection<ConsoleKey> keys =
            new BlockingCollection<ConsoleKey>();

        static void Main()
        {
            Thread t1 = new Thread(GetInput);
            Thread t2 = new Thread(DoStuff);
            t1.Start();
            t2.Start();
            t1.Join();
            t2.Join();


        }

        private static void GetInput()
        {
            ConsoleKey key;

            do
            {
                key = Console.ReadKey(true).Key;
                keys.Add(key);    

            } while (key != ConsoleKey.Escape);
        }

        private static void DoStuff()
        {
            ConsoleKey ck;

            while ((ck = keys.Take()) != ConsoleKey.Escape)
            {
                switch (ck)
                {
                    case ConsoleKey.A:
                        Console.WriteLine("Move left");
                        break;

                    case ConsoleKey.D:
                        Console.WriteLine("Move right");
                        break;

                    case ConsoleKey.S:
                        Console.WriteLine("Move down");
                        break;
                        
                    case ConsoleKey.W:
                        Console.WriteLine("Move up");
                        break;
                }
            }
        }
    }
}
