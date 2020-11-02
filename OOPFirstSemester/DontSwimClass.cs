using System;
namespace OOPFirstSemester
{
    class DontSwimClass : ISwim
    {
        public void Swim()
        {
            Console.WriteLine("Я не плаваю");
        }
    }
}