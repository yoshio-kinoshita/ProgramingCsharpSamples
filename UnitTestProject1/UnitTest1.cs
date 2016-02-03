using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramingCsharpSamples;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            Counter c1 = new Counter();
            Counter c2 = c1;
            c1++;

            Console.WriteLine("c1: " + c1.Count);
            c1++;
            Console.WriteLine("c1: " + c1.Count);
            c1 = c1.GetNextValue();
            Console.WriteLine("c1: " + c1.Count);

            c2++;
            Console.WriteLine("c2: " + c2.Count);
            c1++;
            Console.WriteLine("c1: " + c1.Count);

        }

        [TestMethod]
        public void TestMethod2()
        {
            Counter c1 = new Counter();
            Counter c2 = c1;
            c1++;

            Console.WriteLine("c1: " + c1.Count);
            c1++;
            Console.WriteLine("c1: " + c1.Count);
            c1 = c1.GetNextValue();
            Console.WriteLine("c1: " + c1.Count);

            c2++;
            Console.WriteLine("c2: " + c2.Count);
            c1++;
            Console.WriteLine("c1: " + c1.Count);

        }

        [TestMethod]
        public void DelegateTest()
        {
            int[] bins = {-1, 0, 1,2,3,4,5};
            Assert.AreEqual(2, Array.FindIndex<int>(bins, IsGraterThanZero));

            var p = new Predicate<int>(IsGraterThanZero);

            Predicate<int> p2 = IsGraterThanZero;

            /*
            FindIndex<T>(T[] array, Predicate<T> match)

            public delegate bool Predicate<T>(T obj);
             * 
             */
        }

        private static bool IsGraterThanZero(int value)
        {
            return value > 0;

        }

    }
}
