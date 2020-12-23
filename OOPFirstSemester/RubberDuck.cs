using System;
namespace OOPFirstSemester
{
    class RubberDuck : Duck
    {

        public RubberDuck() : base(new DontFlyClass(), new PeepQuackClass(), new DontWalkClass(), new SwimClass())
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Резиновая утка");
            base.ShowInfo();
        }
    }
}