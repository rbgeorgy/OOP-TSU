namespace OOPFirstSemester
{
    abstract class BirdForSale
    {
        private readonly BirdForSale _birdForSale;

        protected BirdForSale(BirdForSale birdForSale)
        {
            _birdForSale = birdForSale;
        }

        protected BirdForSale()
        {

        }

        public decimal Price()
        {
            return GetPrice() + (_birdForSale?.Price() ?? 0);
        }

        public string Info()
        {
            return (_birdForSale?.Info() ?? "") + GetInfo();
        }


        protected abstract decimal GetPrice();

        protected abstract string GetInfo();
    }
}