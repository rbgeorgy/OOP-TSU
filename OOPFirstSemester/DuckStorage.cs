using System;

namespace OOPFirstSemester
{
    class DuckStorage
    {
        public DuckArrayBase Storage;

        private DuckStorage()
        {
            init();
        }

        private void init()
        {
            Storage = new DuckArrayBase();
            Console.WriteLine("Singletone has been created");
        }

        private static DuckStorage _item;

        public static DuckStorage Get()
        {
            if (_item == null)
            {
                _item = new DuckStorage();
            }
            return _item;
        }
    }
}