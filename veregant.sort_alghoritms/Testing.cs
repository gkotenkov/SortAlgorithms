using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veregant.sort_alghoritms
{
    internal static class Test
    {
        public static void BubbleSort()
        {
            Array array = new Array(new BubbleSort());
            array.Test();
        }

        public static void CocktailSort()
        {
            Array array = new Array(new CocktailSort());
            array.Test();
        }

        public static void MergeSort()
        {
            Array array = new Array(new MergeSort());
            array.Test();
        }

        public static void QuickSort()
        {
            Array array = new Array(new QuickSort());
            array.Test();
        }

        public static void HeapSort()
        {
            Array array = new Array(new HeapSort());
            array.Test();
        }

        public static void RadixSort()
        {
            Array array = new Array(new RadixSort());
            array.Test();
        }
    }
}
