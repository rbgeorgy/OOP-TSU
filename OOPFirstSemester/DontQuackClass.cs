using System;
namespace OOPFirstSemester
{
    class DontQuackClass : IQuack
    {
        public void Quack()
        {
            Console.WriteLine("Я не крякаю");
        }
    }
}