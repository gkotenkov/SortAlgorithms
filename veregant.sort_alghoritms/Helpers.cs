using System.Collections.Generic;

namespace veregant.sort_alghoritms
{
    public abstract class Helpers
    {
        public static void Swap(ref int _first, ref int _second)
        {
            int temp = _first;
            _first = _second;
            _second = temp;
        }
    }
}
