using P129GenericTypeConstraint.Interfaces;
using P129GenericTypeConstraint.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129GenericTypeConstraint.Lists
{
    //Generic Type Collection
    class MyList<T,U> where T : class,new() where U : struct
    {
        private T[] _arr;

        public MyList()
        {
            _arr = new T[0];
        }

        public void Add(T item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public T ElementAt(int index)
        {
            if (index >= 0 && index < _arr.Length)
            {
                return _arr[index];
            }

            throw new IndexOutOfRangeException($"Daxil Edilen Index = {index} Duzgun Deyil");
        }
    }
}
