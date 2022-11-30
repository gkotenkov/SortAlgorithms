namespace veregant.sort_alghoritms
{
    public abstract class Helpers<T>
    {

        /// <summary>
        /// Swap two elems of array. Generic method for all types
        /// </summary>
        /// <param name="_first">reference of 1st elem</param>
        /// <param name="_second">reference of 2nd param</param>
        public static void Swap(ref T _first, ref T _second)
        {
            var temp = _first;
            _first = _second;
            _second = temp;
        }


        /// <summary>
        /// 
        /// </summary>
        /// <param name="_integers">Array of numbers</param>
        /// <returns>Maximum value of param</returns>
        public static int GetMaxVal(int[] _integers)
        {
            var maxval = _integers[0];

            foreach (int integer in _integers)
            {
                if (maxval < integer)
                {
                    maxval = integer;
                }
            }

            return maxval;
        }
    }
}
