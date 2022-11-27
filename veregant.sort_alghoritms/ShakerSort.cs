namespace veregant.sort_alghoritms
{
    internal class ShakerSort : ISorted
    {
        public void Shaker(ref int[] _integers)
        {
            if (_integers == null)
            {

            }

            int left = 0;
            int right = _integers.Length - 1;

            while (left <= right)
            {
                for (int i = right; i > left; i--)
                {
                    if (_integers[i - 1] > _integers[i])
                    {
                        Helpers.Swap(ref _integers[i - 1], ref _integers[i]);
                    }
                }
                left++;
                for (int i = left; i < right; i++)
                {
                    if (_integers[i] > _integers[i + 1])
                    {
                        Helpers.Swap(ref _integers[i + 1], ref _integers[i]);
                    }
                }
                right--;
            }
        }


        public int[] Sort(int[] _integers)
        {
            Shaker(ref _integers);

            return _integers;
        }
    }
}
