using System;
namespace OOPFirstSemester
{
    class DontWalkClass : IWalk
    {
        public void Walk()
        {
            Console.WriteLine("Не умею ходить");
        }
    }
}