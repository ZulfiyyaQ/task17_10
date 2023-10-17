using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace task17_10.Models
{
    internal class ListInt
    {
        private int[] _array;

        public ListInt()
        {
            _array = new int[0];
        }
        public ListInt(int length)
        {
            _array = new int[length];
        }

        public ListInt(params int[] arr)
        {
            _array = arr;
        }

        public int Length { get { return _array.Length; } }
        public int this[int index]
        {
            get
            {
                if (index < _array.Length)
                {
                    return _array[index];
                }
                return _array[_array.Length - 1];


            }
            set
            {
                if (index < _array.Length)
                {
                    _array[index] = value;
                }

            }
        }
        public void Add(int num)
        {
            Array.Resize(ref _array, Length + 1);
            _array[_array.Length - 1] = num;
        }
        public  void AddRange( params int[] nums)
        {
            
            Array.Resize(ref _array, _array.Length+nums.Length);

            for (int i = 0; i < nums.Length; i++)
            {
               _array[(_array.Length-nums.Length+i)] = nums[i];
            }
        }
        public  bool Contains( int num)
        {
            foreach (int item in _array)
            {
                if (item == num)
                {
                    return true;
                }
            }
            return false;
        }
        public  int Sum()
        {
            int sum = 0;
            foreach (int num in _array)
            {
                sum += num;
            }
            return sum;
        }


        public  int[] Remove(int num)
        {

            int[] _result = new int[0];

            foreach (int i in _array)
            {
                if (i != num)
                {
                    Array.Resize(ref _result, _result.Length + 1);
                    _result[_result.Length - 1] = i;
                }
            }

            return _result;
        }
        public void RemoveRange(params int[]nums)
        {
            foreach(int i in nums)
            {
                Remove(i);
            }
        }
        public override string ToString()
        {
            if (_array.Length == 0)
            {
                return "Empty Array";
            }
            return string.Join(", ", _array);


        }



    }
}
