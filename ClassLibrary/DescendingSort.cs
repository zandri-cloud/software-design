using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class DescendingSort
    {
        public int[] SortDescending(int[] numbers)
        {
            for (int j = 0; j < numbers.Length - 1; j++)
            {   
                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    // only change is this comparison
                    if (numbers[i] < numbers[i + 1])
                    {
                        int temp = numbers[i];
                        numbers[i] = numbers[i + 1];
                        numbers[i + 1] = temp;
                    }
                }
            }
            return numbers;
        }
    }
}
