namespace veregant.sort_alghoritms
{
    internal class HeapSort : ISorted
    {
        public void Heap(ref int[] _integers)
        {
            int n = _integers.Length;

            for (int i = n / 2 - 1; i >= 0; i--)
                Heapify(ref _integers, n, i);

            for (int i = n - 1; i >= 0; i--)
            {
                int temp = _integers[0];
                _integers[0] = _integers[i];
                _integers[i] = temp;

                Heapify(ref _integers, i, 0);
            }
        }


        void Heapify(ref int[] _integers, int n, int i)
        {
            int largest = i;
            int l = 2 * i + 1;
            int r = 2 * i + 2;

            if (l < n && _integers[l] > _integers[largest])
                largest = l;

            if (r < n && _integers[r] > _integers[largest])
                largest = r;

            if (largest != i)
            {
                Helpers.Swap(ref _integers[i], ref _integers[largest]);

                Heapify(ref _integers, n, largest);
            }
        }


        public int[] Sort(int[] _integers)
        {
            Heap(ref _integers);

            return _integers;
        }
    }
}
