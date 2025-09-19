using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericsProject
{
    class PrintService<T>
    {
        private T[] _values = new T[10];
        private int _count = 0;

        public void AddValue(T value)
        {
            if(_count == 10) { 
                throw new InvalidOperationException("PrintService is full");
            }

            if (_count == _values.Length)
            {
                Array.Resize(ref _values, _values.Length * 2);
            }
            _values[_count] = value;
            _count++;
        }
        public T First()
        {
            if (_count == 0)
            {
                throw new InvalidOperationException("PrintService is empty");
            }
            return _values[0];
        }
public void Print()
{
    Console.Write("[");
    for (int i = 0; i < _count; i++)
    {
        Console.Write(_values[i]);
        if (i < _count - 1)
        {
            Console.Write(", ");
        }
    }
    Console.WriteLine("]");
}

    }
}
