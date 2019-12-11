using System;

namespace Indexers
{
    class Program
    {
        static void Main(string[] args)
        {
            MyVector v1 = new MyVector(3, 5);
            MyVector v2 = new MyVector(70, 5);

            Console.WriteLine($"vector 1 = {v1.X}; vector 2 = {v2.Y}");

            v1[0] = 90;
            v2[1] = 30;

            Console.WriteLine($"vector 1 = {v1.X}; vector 2 = {v2.Y}");

            v1["a"] = 1;
            v2["y"] = 1000;
            
            Console.WriteLine($"vector 1 = {v1.X}; vector 2 = {v2.Y}");
        }
    }
}
