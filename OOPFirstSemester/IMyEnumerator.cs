using System;
using System.Collections.Generic;

namespace OOPFirstSemester
{
    interface IMyEnumerator<T>
    {
        T Current();
        void Next();

    }
}