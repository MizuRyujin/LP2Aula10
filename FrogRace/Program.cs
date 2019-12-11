using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        private static Random rnd;
        private static object threadLock;

        static void Main()
        {
            rnd = new Random();
            threadLock = new object();
            Thread frog1 = new Thread(FrogRace);
            Thread frog2 = new Thread(FrogRace);
            Thread frog3 = new Thread(FrogRace);
            frog1.Start(1);
            frog2.Start(2);
            frog3.Start(3);
            frog1.Join();
            frog2.Join();
            frog3.Join();
        }

        static void FrogRace(object frog)
        {
            int nFrog = (int)frog;


            for (int i = 0; i <= 10; i++)
            {
                int waitForMiliseconds;

                //lock (threadLock)
                //{
                    waitForMiliseconds = rnd.Next(1000);
                //}

                Thread.Sleep(waitForMiliseconds);

                Console.WriteLine($"Frog {nFrog} leaped {i} times (wait time = {waitForMiliseconds})");

            }

        }
    }
}
