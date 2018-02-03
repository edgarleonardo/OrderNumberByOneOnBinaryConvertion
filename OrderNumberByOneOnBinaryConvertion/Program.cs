using System;
using System.Linq;

namespace OrderNumberByOneOnBinaryConvertion
{
    class Program
    {
        static int[] Rearrange(int[] elements)
        {

            int swaped = 1;
            int n = elements.Length;
            int size = n;
            do
            {
                swaped = 0;
                for (int count = 1; count < n; count++)
                {
                    if (
                        DecimalToBinaryCount(elements[count - 1]) >
                        DecimalToBinaryCount(elements[count])
                    )
                    {
                        Swap(elements, count - 1, count);
                        swaped = 1;
                    }
                }
            } while (swaped == 1);
            var list = elements.ToList().Select(g => g).Distinct().ToArray();

            return list;
        }
        static void Swap(int[] items, int left, int right)
        {
            if (left != right)
            {
                int temp = items[left];
                items[left] = items[right];
                items[right] = temp;
            }
        }
        static int DecimalToBinaryCount(int n)
        {
            int remainder;
            long i = 1;
            int numberOf1s = 0;
            while (n != 0)
            {
                remainder = n % 2;
                n = n / 2;
                if (remainder == 1)
                {
                    numberOf1s++;
                }
            }
            return numberOf1s;
        }
        static void Main(string[] args)
        {
            int[] res;

            int _elements_size = 0;
            _elements_size = Convert.ToInt32(Console.ReadLine());
            int[] _elements = new int[_elements_size];
            int _elements_item;
            for (int _elements_i = 0; _elements_i < _elements_size; _elements_i++)
            {
                _elements_item = Convert.ToInt32(Console.ReadLine());
                _elements[_elements_i] = _elements_item;
            }

            res = Rearrange(_elements);
            for (int res_i = 0; res_i < res.Length; res_i++)
            {
                Console.WriteLine(res[res_i]);
            }
            Console.ReadKey();
        }
    }
}