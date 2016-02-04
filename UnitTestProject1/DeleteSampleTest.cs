using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ProgramingCsharpSamples;

namespace UnitTestProject
{
    [TestClass]
    public class DeleteSampleTest
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
            int[] bins = { -1, 0, 1, 2, 3, 4, 5 };
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

        [TestMethod()]
        public void GetIndexOfFirstNonEmptyBinTest()
        {
            int[] bins = { -1, 0, 1, 2, 3, 4, 5 };
            int index = DelegateSample.GetIndexOfFirstNonEmptyBin(bins);
            Assert.AreEqual(2, index);

        }

        [TestMethod()]
        public void ThresholdComparerTest()
        {
            ThresholdComparer zeroThreashold = new ThresholdComparer { Threhold = 0 };
            ThresholdComparer tenThreshold = new ThresholdComparer { Threhold = 10 };
            ThresholdComparer hundredThreshold = new ThresholdComparer { Threhold = 100 };

            Predicate<int> graterThanZero = zeroThreashold.IsGraterThan;
            Predicate<int> tenThanZero = tenThreshold.IsGraterThan;
            Predicate<int> handredThanZero = hundredThreshold.IsGraterThan;

            // Create Delegate
            Predicate<int> createDelegate = (Predicate<int>)Delegate.CreateDelegate(typeof(Predicate<int>), zeroThreashold, "IsGraterThan");

            Assert.IsTrue(graterThanZero(1));
            Assert.IsTrue(tenThanZero(11));
            Assert.IsFalse(graterThanZero(-1));
        }

        [TestMethod()]
        public void CombineDelete()
        {
            ThresholdComparer zeroThreashold = new ThresholdComparer { Threhold = 0 };
            ThresholdComparer tenThreshold = new ThresholdComparer { Threhold = 10 };
            ThresholdComparer hundredThreshold = new ThresholdComparer { Threhold = 100 };
            Predicate<int> graterThanZero = zeroThreashold.IsGraterThan;
            Predicate<int> tenThanZero = tenThreshold.IsGraterThan;
            Predicate<int> handredThanZero = hundredThreshold.IsGraterThan;

            Predicate<int> combinePredicate =
                graterThanZero + tenThanZero + handredThanZero;

            Assert.IsFalse(combinePredicate(5));
            Assert.IsTrue(combinePredicate(101));
            Assert.IsFalse(combinePredicate(99));

             foreach (Predicate<int> d in combinePredicate.GetInvocationList())
             {
                 Assert.IsTrue(d(101));
             }

        }
    }

}
