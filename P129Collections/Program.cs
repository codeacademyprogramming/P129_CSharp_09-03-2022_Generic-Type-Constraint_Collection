using System;
using System.Collections;
using System.Collections.Generic;

namespace P129Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Non Generic
            //ArrayList arrayList = new ArrayList();
            //arrayList.Add("Hello");
            //arrayList.Add('W');
            //arrayList.Add(54);
            //arrayList.Add(true);
            //arrayList.Add("Hello");
            //arrayList.Add('W');
            //arrayList.Add(54);
            //arrayList.Add(true);

            //ArrayList arrayList1 = new ArrayList();
            //arrayList1.Add(15);
            //arrayList1.Add("P129");
            //arrayList1.AddRange(arrayList);

            //arrayList.Clear();
            //Console.WriteLine(arrayList.Count);
            //Console.WriteLine(arrayList.Contains("Test"));
            //Console.WriteLine(arrayList.IndexOf("Hello", arrayList.IndexOf("Hello")+1));
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("==========");
            //arrayList.InsertRange(3, arrayList1);
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //Console.WriteLine(arrayList.Count);
            ////arrayList.Remove("Hello");
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine("==========");
            ////arrayList.RemoveAt(3);
            ////arrayList.RemoveRange(2, 3);
            //arrayList.Reverse();
            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}
            //Console.WriteLine(arrayList.Count);

            //SortedList sortedList = new SortedList();
            //sortedList.Add("Uc", "Ucuncu");
            //sortedList.Add("Bes", "Besinci");
            //sortedList.Add("Iki", "Ikinci");

            //foreach (var item in sortedList.Values)
            //{
            //    Console.WriteLine(item);
            //}

            //FIFO - First In First Out
            //Queue queue = new Queue();
            //queue.Enqueue("Hello");
            //queue.Enqueue("World");
            //queue.Enqueue("P129");
            //queue.Enqueue(18);

            //Console.WriteLine(queue.Peek());

            //foreach (var item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //var test = queue.Dequeue();
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());
            //Console.WriteLine(queue.Dequeue());

            //Console.WriteLine(queue.Peek());

            //LIFO - Last In First Out
            //Stack stack = new Stack();
            //stack.Push("Hello");
            //stack.Push("World");
            //stack.Push("P129");
            //stack.Push(18);

            //Console.WriteLine(stack.Peek());
            //var test = stack.Pop();
            //Console.WriteLine(test);
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            //Console.WriteLine(stack.Pop());
            //Console.WriteLine(stack.Peek());
            #endregion

            #region Generic
            //Dictionary<string, string> phones = new Dictionary<string, string>();
            //phones.Add("Hamid", "+9445555555");
            //phones.Add("Perviz", "+9445555555");
            //phones.Add("Alyasar", "+9445555555");
            //foreach (var item in phones)
            //{
            //    Console.WriteLine($"Ad: {item.Key}\tTel: {item.Value}");
            //}

            //List<string> strList = new List<string>();
            //strList.Add("Test");
            //strList.Add("Test");
            //strList.Add("Test");
            //strList.Add("Test");
            //strList.Add("Test");
            //strList[4] = "Hello";
            //Console.WriteLine(strList[4]);

            //foreach (string item in strList)
            //{
            //    Console.WriteLine(item);
            //}

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Hello-1");
            //queue.Enqueue("Hello-2");
            //queue.Enqueue("Hello-3");

            //queue.Peek();

            //queue.Dequeue();

            //foreach (string item in queue)
            //{
            //    Console.WriteLine(item);
            //}

            //Stack<int> stack = new Stack<int>();
            //stack.Push(151);
            //stack.Push(152);
            //stack.Push(153);

            //stack.Peek();

            //stack.Pop();

            //foreach (int item in stack)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion
        }
    }
}
