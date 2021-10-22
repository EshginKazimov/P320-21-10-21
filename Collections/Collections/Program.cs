using System;
using System.Collections;
using System.Collections.Generic;

namespace Collections
{
    class Program
    {
        static void Main(string[] args)
        {
            #region Homework

            //Person p1 = new Person("Elvin", "Memmedov", 26);
            //Person p2 = new Person("Namik", "Aliyev", 18);
            //Person p3 = new Person("Ehmed", "Veliyev", 36);

            //Person[] arr = { p1, p2, p3 };

            //Array.Sort(arr);

            //foreach (var item in arr)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region IEnumerable

            //MyList<int> numbers = new MyList<int>();
            //numbers.AddItem(1);
            //numbers.AddItem(1);
            //numbers.AddItem(1);
            //numbers.AddItem(1);
            //foreach (int item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Arraylist, List<>

            //ArrayList arrayList = new ArrayList();
            //arrayList.Add(1);
            //arrayList.Add("Elnur");
            //arrayList.Add(false);
            //arrayList.Add(5.6);
            ////arrayList.Clear();
            //arrayList.Add(10);
            //arrayList.Remove(10);
            //arrayList.RemoveAt(0);
            ////arrayList.RemoveRange(1, 2);

            //foreach (var item in arrayList)
            //{
            //    Console.WriteLine(item);
            //}

            //List<int> numbers = new List<int>();
            //numbers.Add(5);
            ////numbers.Add("");
            //numbers.Add(10);
            //numbers.Add(10);
            //numbers.Add(10);

            ////bool isExist = numbers.Contains(6);
            ////Console.WriteLine(isExist);

            //numbers.Remove(5);
            //numbers.RemoveAt(0);
            ////numbers.RemoveRange();

            //foreach (var item in numbers)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Hashtable, Dictionary

            //Hashtable hashtable = new Hashtable();
            //hashtable.Add('a', "Elnur");
            //hashtable.Add('b', "Akif");
            //hashtable.Add('c', "Emil");
            //hashtable.Add('c', "Parviz");

            //Console.WriteLine(hashtable['c']);

            //foreach (var item in hashtable)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<int, string> dictionary = new Dictionary<int, string>();
            //dictionary.Add(1, "Elnur");
            //dictionary.Add(2, "Alisimran");
            //dictionary.Add(3, "Idris");

            //foreach (var item in dictionary)
            //{
            //    Console.WriteLine(item);
            //}

            //Dictionary<string, List<Person>> dictionary = new Dictionary<string, List<Person>>();
            //dictionary.Add("P320", new List<Person>
            //{
            //    new Person("Elnur1", "Meherremli", 28),
            //    new Person("Elnur1", "Meherremli", 28),
            //    new Person("Elnur1", "Meherremli", 28),
            //    new Person("Elnur1", "Meherremli", 28),
            //});
            //dictionary.Add("P321", new List<Person>
            //{
            //    new Person("Elnur", "Meherremli", 28),
            //    new Person("Elnur", "Meherremli", 28),
            //    new Person("Elnur", "Meherremli", 28),
            //    new Person("Elnur", "Meherremli", 28),
            //});

            //List<Person> p320Group = dictionary["P321"];
            //foreach (var item in p320Group)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedDictionary<int, string> sortedDictionary = new SortedDictionary<int, string>();
            //sortedDictionary.Add(2, "Elnur");
            //sortedDictionary.Add(1, "Akif");
            //sortedDictionary.Add(3, "Namik");

            //foreach (var item in sortedDictionary)
            //{
            //    Console.WriteLine(item);
            //}

            //SortedDictionary<string, string> sortedDictionary = new SortedDictionary<string, string>();
            //sortedDictionary.Add("b", "Test");
            //sortedDictionary.Add("a", "Test");
            //sortedDictionary.Add("A", "Test");

            //foreach (var item in sortedDictionary)
            //{
            //    Console.WriteLine(item);
            //}

            #endregion

            #region Queue - FIFO

            //Queue<string> queue = new Queue<string>();
            //queue.Enqueue("Tebriz");
            //queue.Enqueue("Elvin");
            //queue.Enqueue("Azim");
            //queue.Enqueue("Aydin");

            //Console.WriteLine("Sira kimdedir? " + queue.Peek());

            //queue.Dequeue();
            //Console.WriteLine("Sira kimdedir? " + queue.Peek());

            #endregion

            #region Stack - LIFO

            //Stack<string> stack = new Stack<string>();
            //stack.Push("Tebriz");
            //stack.Push("Elvin");
            //stack.Push("Azim");
            //stack.Push("Aydin");

            //Console.WriteLine("Sira kimdedir? " + stack.Peek());

            //stack.Pop();
            //Console.WriteLine("Sira kimdedir? " + stack.Peek());

            #endregion

            #region LinkedList

            //LinkedList<string> linkedList = new LinkedList<string>();
            //var firstNode = linkedList.AddFirst("Parviz");
            //var secondNode = linkedList.AddAfter(linkedList.First, "Orkhan");
            //var node = linkedList.AddBefore(secondNode, "Idris");

            ////linkedList.First.Value;
            ////linkedList.Last.Value;
            //Console.WriteLine(secondNode.Previous.Value);

            #endregion

            //Oz yaratdiginiz mylist class-ini 
            //Foreach dongusune salmaq
        }
    }

    class Person : IComparable, IComparable<Person>
    {
        public string Name { get;}

        public string Surname { get; }

        public int Age { get; }

        public Person(string name, string surname, int age)
        {
            Name = name;
            Surname = surname;
            Age = age;

        }

        public int CompareTo(object obj)
        {
            Person person = (Person)obj;

            return Age.CompareTo(person.Age);
        }

        public override string ToString()
        {
            return $"{Name} {Surname} {Age}";
        }

        public int CompareTo(Person p1)
        {
            return Age.CompareTo(p1.Age);
        }
    }

    class MyList<T>
    {
        private T[] _items;

        public MyList()
        {
            _items = new T[0];
        }

        public void AddItem(T value)
        {
            Array.Resize(ref _items, _items.Length + 1);
            _items[_items.Length - 1] = value;
        }

        public void ShowItems()
        {
            foreach (T item in _items)
            {
                Console.WriteLine(item);
            }
        }
    }
}
