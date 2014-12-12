using System;
using System.Text;
using System.Collections.Generic;


namespace Other_Types_in_OOP
{
    [VersionsAttribute(12, 44)]
    class GenericListExample
    {
        static void Main()
        {
            // Declare a list of type int 
            //ADD
            // Declare a list of type string
            GenericList<string> stringList = new GenericList<string>();
            stringList.Add("C#");
            stringList.Add("Java");
            stringList.Add("PHP");
            stringList.Add("SQL");
            stringList.Add("C++");
            stringList.Add("ASP");
            stringList.Add("PITON");
            Console.WriteLine("Number of elements: {0}", stringList.Count);
            stringList.ToString();
            Console.WriteLine();
            //Remove
            int remIndex = 2;
            stringList.Remove(remIndex);
            Console.WriteLine("REMOVED index: {0}", remIndex);
            stringList.ToString();
            //GET BY INDEX
            Console.WriteLine();
            int getIndex = 1;
            Console.WriteLine("GET BY INDEX: " + getIndex);
            Console.WriteLine(stringList[getIndex]);
            //ADD FROM INDEX
            Console.WriteLine();
            int insIndex = 2;
            string insValue = ".NET";
            Console.WriteLine("INSERT index = {0}, value = {1}", insIndex, insValue);
            stringList.Insert(insIndex, insValue);
            stringList.ToString();
            Console.WriteLine();
            //FIND
            Console.WriteLine("FIND:");
            stringList.Find("SQL");
            Console.WriteLine();
            //MIN Compare
            Console.WriteLine();
            Console.WriteLine("MIN compare");
            string res = GenericList<string>.Min<string>(stringList[2], stringList[6]);
            Console.WriteLine("min = {0}",res);
            int resIntMin = GenericList<int>.Min<int>(10, 20);
            Console.WriteLine(resIntMin);
            //MAX Compare
            Console.WriteLine();
            Console.WriteLine("MAX compare");
            string resMax = GenericList<string>.Max<string>(stringList[0], stringList[2]);
            Console.WriteLine("max = {0}", resMax);
            int resInt = GenericList<int>.Max<int>(10, 20);
            Console.WriteLine(resInt);
            //CLEAR
            Console.WriteLine();
            Console.WriteLine("CLEAR");
            stringList.Clear();
            stringList.ToString();
            Console.WriteLine();
            //Version
            Console.WriteLine("VERSION:");
            Type type = typeof(GenericListExample);
            object[] allAtributes = type.GetCustomAttributes(false);
            foreach (VersionsAttribute allAtt in allAtributes)
            {
                Console.WriteLine("Version: "+ allAtt.ToString());
            }
        }
    }

    public class GenericList<T> where T : IComparable<T>
    {
        const int DefaultCapacity = 16;

        private T[] elements;
        private int count = 0;
        //constructopr
        public GenericList(int capacity = DefaultCapacity)
        {
            elements = new T[capacity];
        }
        //property Count
        public int Count
        {
            get
            {
                return this.count;
            }
        }
        //METHODS
        //Add
        public void Add(T element)
        {
            if (count >= elements.Length)
            {
                T[] elementsCopy;
                elementsCopy = new T[this.elements.Length * 2];
                elements.CopyTo(elementsCopy, 0);
                Array.Clear(elements, 0, elements.Length);
                Array.Resize<T>(ref elements, elementsCopy.Length);

                elementsCopy.CopyTo(elements, 0);

            }

            this.elements[count] = element;
            count++;
        }
        //Remove
        public void Remove(int index)
        {
            if (index >= this.Count)
            {
                throw new ArgumentOutOfRangeException();
            }

            count--;
            if (index < this.Count)
            {
                T[] elementsCopy;
                elementsCopy = new T[this.elements.Length];
                elements.CopyTo(elementsCopy, 0);
                Array.Resize<T>(ref elements, elements.Length - 1);
                Array.Clear(elements, 0, elements.Length);

                for (int i = 0; i < index; i++)
                {
                    elements[i] = elementsCopy[i];
                }


                for (int i = index; i < elements.Length; i++)
                {
                    int j = i + 1;
                    elements[i] = elementsCopy[j];
                }


            }
            //for (int i = 0; i < elements.Length; i++)
            //{
            //    elements[i] = this.Count[i];
            //}

        }
        //get element by index
        public T this[int index]
        {
            get
            {
                if (index < 0 || index >= count)
                {
                    throw new IndexOutOfRangeException(String.Format(
                        "Invalid index: {0}.", index));
                }
                T result = elements[index];
                return result;
            }
        }
        //Insert
        public void Insert(int index, T item)
        {
            Array.Resize<T>(ref elements, elements.Length + 1);
            T[] elementsCopy;
            elementsCopy = new T[this.elements.Length];
            elements.CopyTo(elementsCopy, 0);
            Array.Clear(elements, 0, elements.Length);

            count++;
            for (int i = 0; i <= index; i++)
            {
                elements[i] = elementsCopy[i];
                if (i == index)
                {
                    elements[index] = item;
                }
            }

            for (int i = index + 1; i < elements.Length; i++)
            {
                int j = i - 1;
                elements[i] = elementsCopy[j];
            }
            //elementsCopy.CopyTo(elements, 0);


        }
        //CLEAR
        public void Clear()
        {
            Array.Clear(elements, 0, elements.Length);
        }
        //FIND
        public void Find(T item)
        {
            int res = 0;
            dynamic findelement;

            for (int i = 0; i < elements.Length; i++)
            {
                findelement = elements[i];
                if (findelement == item)
                {
                    res = i;
                    break;
                }
            }
            Console.WriteLine(String.Format("Index of element({0}): {1}", item, res));

        }
        //override ToString()
        public override string ToString()
        {
            string res = "";
            for (int i = 0; i < elements.Length; i++)
            {
                dynamic element = elements[i];
                Console.WriteLine("index = {0}, value = {1}", i, element);
            }
            return res;
        }
        //MinT>
        public static T Min<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second)<=0)
            {
                return first;
            }
            else
            {
                return second;
            }
        }
        //MaxT>
        public static T Max<T>(T first, T second)
            where T : IComparable<T>
        {
            if (first.CompareTo(second) <= 0)
            {
                return second;
            }
            else
            {
                return first;
            }
        }
    }
}


