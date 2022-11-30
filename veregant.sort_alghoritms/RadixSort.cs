using System;

namespace veregant.sort_alghoritms
{
    internal class RadixSort : ISorted
    {
        public static void CountingSort(ref int[] _integers, int _exponent)
        {
            var outputArr = new int[_integers.Length];

            var occurences = new int[10];

            for (int i = 0; i < 10; i++)
            {
                occurences[i] = 0;
            }

            for (int i = 0; i < _integers.Length; i++)
            {
                occurences[(_integers[i] / _exponent) % 10]++;
            }

            for (int i = 1; i < 10; i++)
            {
                occurences[i] += occurences[i - 1];
            }

            for (int i = _integers.Length - 1; i >= 0; i--)
            {
                outputArr[occurences[(_integers[i] / _exponent) % 10] - 1] = _integers[i];
                occurences[(_integers[i] / _exponent) % 10]--;
            }

            for (int i = 0; i < _integers.Length; i++)
            {
                _integers[i] = outputArr[i];
            }
        }

        public int[] Radix(ref int[] _integers)
        {
            var maxVal = Helpers<int>.GetMaxVal(_integers);

            for (int exponent = 1; maxVal / exponent > 0; exponent *= 10)
            {
                CountingSort(ref _integers, exponent);
            }

            return _integers;
        }

        public int[] Sort(int[] _integers)
        {
            Radix(ref _integers);

            return _integers;
        }

        
    }
}
