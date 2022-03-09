using System;
using System.Collections.Generic;
using System.Text;

namespace P129GenericTypeConstraint.Models
{
    class Student : Human
    {
        public string Name { get; set; }
        public string SurName { get; set; }
        public int Age { get; set; }
    }
}
