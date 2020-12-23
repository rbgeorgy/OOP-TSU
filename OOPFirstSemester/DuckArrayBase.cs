using System;
using System.Collections;
using System.Collections.Generic;

namespace OOPFirstSemester
{
    class DuckArrayBase : IMyEnumerator<Duck> {

        protected List<Duck> _array;
        protected int _current;
        
        public Duck Current()
        {
            return _array[_current];
        }

        public void Next()
        {
            _current++;
        }

        public void PrintAll()
        {
            Console.WriteLine("Список содержит уток со следующими свойствами:");
            foreach (var i in _array)
            {
                i.ShowInfo();
            }
        }

        public void PrintCurrent()
        {
            Console.WriteLine("Текущая утка:");
            _array[_current].ShowInfo();
        }

    }
}