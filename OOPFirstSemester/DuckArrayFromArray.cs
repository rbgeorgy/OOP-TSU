using System.Linq;

namespace OOPFirstSemester
{
    class DuckArrayFromArray : DuckArrayBase
    {

        public DuckArrayFromArray(Duck[] arr)
        {

            _array = arr.ToList();
            _current = 0;

        }

    }
}