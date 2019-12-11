using System;
using System.Threading;

namespace FrogRace
{
    class Program
    {
        static void Main(string[] args)
        {
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

            Random rnd = new Random(nFrog + nFrog * 2);

            for (int i = 0; i <= 10; i++)
            {
                Console.WriteLine($"Frog {nFrog} leaped {i} times");

                Thread.Sleep(rnd.Next(1000));
            }

        }
    }
}
