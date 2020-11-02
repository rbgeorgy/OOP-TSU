using System;
namespace OOPFirstSemester
{
    class DontFlyClass : IFly
    {
        public void Fly()
        {
            Console.WriteLine("Я не летаю");
        }
    }
}