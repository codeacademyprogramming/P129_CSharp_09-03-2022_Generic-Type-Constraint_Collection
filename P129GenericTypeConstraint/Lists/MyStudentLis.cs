using P129GenericTypeConstraint.Models;
using System;
using System.Collections.Generic;
using System.Text;

namespace P129GenericTypeConstraint.Lists
{
    class MyStudentLis
    {
        private Student[] _arr;

        public MyStudentLis()
        {
            _arr = new Student[0];
        }

        public void Add(Student item)
        {
            Array.Resize(ref _arr, _arr.Length + 1);
            _arr[_arr.Length - 1] = item;
        }

        public Student ElementAt(int index)
        {
            if (index >= 0 && index < _arr.Length)
            {
                return _arr[index];
            }

            throw new IndexOutOfRangeException($"Daxil Edilen Index = {index} Duzgun Deyil");
        }
    }
}
