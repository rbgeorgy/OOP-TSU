namespace OOPFirstSemester
{
    class StuffedBird : BirdForSale
    {
        public StuffedBird(BirdForSale birdForSale) : base(birdForSale)
        {

        }

        protected override decimal GetPrice()
        {
            return 50;
        }

        protected override string GetInfo()
        {
            return " + фаршированная";
        }
    }
}