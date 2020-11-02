using System;
namespace OOPFirstSemester
{
    class Duck
    {

        private IFly _fly;
        private IQuack _quack;
        private IWalk _walk;
        private ISwim _swim;
        private BirdForSale _birdForSale;

        public BirdForSale BirdForSaleProp
        {
            get { return _birdForSale; }
        }

        public BirdForSale BirdForSalePropSet
        {
            set { _birdForSale = value; }
        }



        public virtual void FPropFunc()
        {
            _fly.Fly();
        }

        public virtual void QPropFunc()
        {
            _quack.Quack();
        }

        public virtual void WPropFunc()
        {
            _walk.Walk();
        }

        public virtual void SPropFunc()
        {
            _swim.Swim();
        }

        public Duck(IFly f, IQuack q, IWalk w, ISwim s)
        {
            _fly = f;
            _quack = q;
            _walk = w;
            _swim = s;
        }

        public Duck()
        {
            _fly = new FlyClass();
            _quack = new QuackClass();
            _walk = new WalkClass();
            _swim = new SwimClass();
        }

        public virtual void ShowInfo()
        {
            FPropFunc();
            QPropFunc();
            WPropFunc();
            SPropFunc();
            Console.WriteLine();
        }

        public void MakeSellable()
        {
            _birdForSale = new StandardBirdForSale();
        }        

    }
}