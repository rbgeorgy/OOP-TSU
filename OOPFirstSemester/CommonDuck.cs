using System;
namespace OOPFirstSemester
{
    class CommonDuck : Duck
    {

        public CommonDuck() : base(new FlyClass(), new QuackClass(), new WalkClass(), new SwimClass())
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Обычная утка");
            base.ShowInfo();
        }
    }
}