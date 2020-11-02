using System;
using System.Collections.Generic;

namespace OOPFirstSemester
{
    class DuckArrayFromList : DuckArrayBase
    {

        public DuckArrayFromList(List<Duck> list)
        {
            _array = list;
        }

    }
}