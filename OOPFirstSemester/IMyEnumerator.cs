using System;
using System.Collections.Generic;

namespace OOPFirstSemester
{
    interface IMyEnumerator<T> : IEnumerable<T>
    {

        T Current(int i);
        void Next();

    }
}