using System;
namespace OOPFirstSemester
{
    class WoodDuck : Duck
    {

        public WoodDuck() : base(new DontFlyClass(), new DontQuackClass(), new DontWalkClass(), new SwimClass())
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Деревянная утка");
            base.ShowInfo();
        }
    }
}