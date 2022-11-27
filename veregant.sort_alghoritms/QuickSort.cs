namespace veregant.sort_alghoritms
{
    internal class QuickSort : ISorted
    {
        public int Partition(ref int[] _integers, int _start, int _end)
        {
            int foot = _integers[_end];
            int index = _start;

            for (int i = _start; i < _end; i++)
            {
                if (_integers[i] <= foot)
                {
                    Helpers.Swap(ref _integers[i], ref _integers[index]);
                    index++;
                }
            }

            Helpers.Swap(ref _integers[index], ref _integers[_end]);

            return index;
        }

        public void Quick(ref int[] _integers, int _start, int _end)
        {
            if (_start >= _end) 
            {
                return;
            }

            int foot = this.Partition(ref _integers, _start, _end);

            Quick(ref _integers, _start, foot-1);
            Quick(ref _integers, foot+1, _end);
        }

        public int[] Sort(int[] _integers)
        {
            int end = _integers.Length - 1;
            int start = 0;
            Quick(ref _integers, start, end);

            return _integers;
        }
    }
}
