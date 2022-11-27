namespace veregant.sort_alghoritms
{
    internal class BubbleSort : ISorted
    {
        public void Bubble(ref int[] _integers)
        {
            int length = _integers.Length;
            for (int i = 0; i + 1 < length; i++)
            {
                for (int j = 0; j + 1 < length - i; j++)
                {
                    if (_integers[j] > _integers[j + 1])
                    {
                        Helpers.Swap(ref _integers[j], ref _integers[j + 1]);
                    }
                }
            }
        }

        public int[] Sort(int[] _integers)
        {   
            Bubble(ref _integers);

            return _integers;
        }
    }
}
