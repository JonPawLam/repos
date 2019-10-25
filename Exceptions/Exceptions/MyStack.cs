using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class MyStack<T> 
    {
        public int _top;
        private int _size;
        private T[] _stack;



        public MyStack(int size)
        {
            _top = 0;
            _size = size;
            _stack = new T[size];

        }

        public void Push(T element)
        {
            Console.WriteLine("Number");

            try
            {
                _stack[_top++] = element;
            }
            catch
            {
                _top--;
                throw  new MyStackIsFullException("Stack Is Full");
            }

        }


        public T Pop()
        {
            try
            {
                return _stack[_top--];
            }
            catch
            {
                ++_top;
                throw new MyStackIsEmtyException("Stack Empty");
            }
            

        }



        public void ListView()
        {
            foreach (var item in _stack)
            {
                Console.WriteLine(item);
            }

        }



    }
}
