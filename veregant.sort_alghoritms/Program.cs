using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace veregant.sort_alghoritms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            BubbleSort bubbleSort = new BubbleSort();
            Array array = new Array(bubbleSort);
            Console.WriteLine(array);
            Console.ReadLine();
        }
    }
}
