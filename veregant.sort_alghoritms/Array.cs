﻿using System;

namespace veregant.sort_alghoritms
{
    internal class Array
    {
        public int[] Integers { get; set; }

        public ISorted Sorted { get; set; }

        public static int Length = 20;

        public Array(ISorted _sorted)
        {
            this.Integers = new int[Length];
            this.Sorted = _sorted;

            Random rnd = new Random();

            for (int i = 0; i < Length; i++)
            {
                Integers[i] = rnd.Next(1, 20);
            }
        }

        public void Sort()
        {
            this.Integers = this.Sorted.Sort(Integers);
        }

        public void Test()
        {
            Console.WriteLine(this);
            this.Sort();
            Console.ReadLine();
            Console.WriteLine(this);
            Console.ReadLine();
        }

        public override string ToString()
        {
            string str = "";
            foreach (int _integer in Integers)
            {
                str += (_integer.ToString() + "\n");
            }
            return str;
        }


    }
}
