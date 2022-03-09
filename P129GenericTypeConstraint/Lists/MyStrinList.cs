using System;
using System.Collections.Generic;
using System.Text;

namespace P129GenericTypeConstraint.Lists
{
    class MyStrinList
    {
        private string[] _arr;

        public MyStrinList()
        {
            _arr = new string[0];
        }

        public void Add(string item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public string ElementAt(int index)
        {
            if (index >=0 && index < _arr.Length)
            {
                return _arr[index];
            }

            throw new IndexOutOfRangeException($"Daxil Edilen Index = {index} Duzgun Deyil");
        }
    }
}
