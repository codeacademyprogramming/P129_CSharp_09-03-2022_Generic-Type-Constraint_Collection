using System;
using P129GenericTypeConstraint.Interfaces;
using P129GenericTypeConstraint.Lists;
using P129GenericTypeConstraint.Models;

namespace P129GenericTypeConstraint
{
    class Program
    {
        static void Main(string[] args)
        {
            //MyStrinList myStrinList = new MyStrinList();
            //myStrinList.Add("Hamid");
            //myStrinList.Add("Perviz");
            //myStrinList.Add("Alyasar");
            //myStrinList.Add("Vasif");
            //myStrinList.Add("Ceyhun");
            //myStrinList.Add("Elgiz");

            //MyIntList myIntList = new MyIntList();
            //myIntList.Add(17);
            //myIntList.Add(19);
            //myIntList.Add(19);
            //myIntList.Add(20);
            //myIntList.Add(19);
            //myIntList.Add(29);

            //MyStudentLis myStudentLis = new MyStudentLis();
            //myStudentLis.Add(new Student { });
            //myStudentLis.Add(new Student { });
            //myStudentLis.Add(new Student { });
            //myStudentLis.Add(new Student { });
            //myStudentLis.Add(new Student { });
            //myStudentLis.Add(new Student { });

            //MyList<string> myStringList = new MyList<string>();
            //myStringList.Add("Hamid");
            //myStringList.Add("Perviz");
            //myStringList.Add("Alyasar");
            //myStringList.Add("Vasif");
            //myStringList.Add("Ceyhun");
            //myStringList.Add("Elgiz");

            //MyList<int> myIntList = new MyList<int>();
            //myIntList.Add(17);
            //myIntList.Add(19);
            //myIntList.Add(19);
            //myIntList.Add(20);
            //myIntList.Add(19);
            //myIntList.Add(29);

            //MyList<Student> myStudentList = new MyList<Student>();
            //myStudentList.Add(new Student { });
            //myStudentList.Add(new Student { });
            //myStudentList.Add(new Student { });
            //myStudentList.Add(new Student { });
            //myStudentList.Add(new Student { });
            //myStudentList.Add(new Student { });

            //MyList<Mentor> myMentorList = new MyList<Mentor>();

            //MyList<Teacher> myTeacherList = new MyList<Teacher>();

            //MyList<Student, Human> myStudentList = new MyList<Student, Human>();
            //MyList<Human, ITest> myHumanList = new MyList<Human, ITest>();


            //MyList<Teacher,object> myTeacherList = new MyList<Teacher, object>();

            //Write<string>("Test");
            //Write<int>(54);
        }
        //Generic Method
        //static T Write<T,U>(T item) where T : class where U:struct
        //{
        //    T result;
        //    return result;
        //}

        //Non-Generict Method
        //static void WriteStr(string item)
        //{
        //    Console.WriteLine(item);
        //}

        //static void WriteInt(int item)
        //{
        //    Console.WriteLine(item);
        //}
    }
}
