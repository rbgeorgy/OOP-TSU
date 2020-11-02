using System;
namespace OOPFirstSemester
{
    class CommonTurkeyCock : TurkeyCock
    {

        public CommonTurkeyCock() : base(new DontFlyClass(), new CluckClass(), new WalkClass(), new DontSwimClass())
        {

        }

        public override void ShowInfo()
        {
            Console.WriteLine("Обычный индюк");
            base.ShowInfo();
        }
    }
}