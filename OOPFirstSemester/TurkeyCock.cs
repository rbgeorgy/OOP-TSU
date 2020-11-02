using System;
namespace OOPFirstSemester
{
    class TurkeyCock
    {
        private IFly _fly;
        private ICluck _cluck;
        private IWalk _walk;
        private ISwim _swim;

        public virtual void FPropFunc()
        {
            _fly.Fly();
        }

        public virtual void CPropFunc()
        {
            _cluck.Cluck();
        }

        public virtual void WPropFunc()
        {
            _walk.Walk();
        }

        public virtual void SPropFunc()
        {
            _swim.Swim();
        }

        public TurkeyCock(IFly f, ICluck c, IWalk w, ISwim s)
        {
            _fly = f;
            _cluck = c;
            _walk = w;
            _swim = s;
        }

        public virtual void ShowInfo()
        {
            FPropFunc();
            CPropFunc();
            WPropFunc();
            SPropFunc();
            Console.WriteLine();
        }


    }
}