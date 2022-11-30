namespace veregant.sort_alghoritms
{
    internal class MergeSort : ISorted
    {
        public void Merge(ref int[] _integers, int _low, int _middle, int _high)
        {
            var left = _low;
            var right = _middle + 1;
            var tempIntegers = new int[_high - _low + 1];
            var index = 0;

            while ((left <= _middle) && (right <= _high))
            {
                if (_integers[left] < _integers[right])
                {
                    tempIntegers[index] = _integers[left];
                    left++;
                }
                else
                {
                    tempIntegers[index] = _integers[right];
                    right++;
                }

                index++;
            }

            for (var i = left; i <= _middle; i++)
            {
                tempIntegers[index] = _integers[i];
                index++;
            }

            for (var i = right; i <= _high; i++)
            {
                tempIntegers[index] = _integers[i];
                index++;
            }

            for (var i = 0; i < tempIntegers.Length; i++)
            {
                _integers[_low + i] = tempIntegers[i];
            }
        }

        public void MergeSorting(ref int[] _integers, int _low, int _high)
        {
            if (_low < _high)
            {
                int middle = (_high + _low) / 2;
                MergeSorting(ref _integers, _low, middle);
                MergeSorting(ref _integers, middle + 1, _high);
                Merge(ref _integers, _low, middle, _high);
            }
        }

        public int[] Sort(int[] _integers)
        {
            MergeSorting(ref _integers, 0, _integers.Length - 1);

            return _integers;
        }
    }
}
