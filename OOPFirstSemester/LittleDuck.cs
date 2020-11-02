using System;
namespace OOPFirstSemester
{
    class LittleDuck : Duck
    {

        public LittleDuck() : base(new DontFlyClass(), new PeepQuackClass(), new WalkClass(), new SwimClass())
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Утёнок");
            base.ShowInfo();
        }
    }
}