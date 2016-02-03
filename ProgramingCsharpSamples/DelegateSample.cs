﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProgramingCsharpSamples
{
    public class DelegateSample
    {

        public static int GetIndexOfFirstNonEmptyBin(int[] bins)
        {
            // new delegate
            var p = new Predicate<int>(IsGraterThanZero);

            // implicitly delegate
            // method group(find method by methodName. if matchd method over two. compiler is error)
            Predicate<int> p2 = IsGraterThanZero;

            return Array.FindIndex(bins, IsGraterThanZero);
        }

        private static bool IsGraterThanZero(int value)
        {
            return value > 0;
        }


        public delegate bool Predicate<T>(T obj);
    }

    internal class Program
    {
        static void main(String[] args)
        {
            // static method in other class 
            Predicate<int> p1 = Tests.IsGraterThanZero;
            // static method in other class 
            Predicate<int> p2 = Tests.IsLessTenZero;
        }
    }
    internal class Tests
    {
        public static bool IsGraterThanZero(int value)
        {
            return value > 0;
        }

        public static bool IsLessTenZero(int value)
        {
            return value < 0;
        }
    }
}
