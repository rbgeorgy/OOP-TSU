namespace OOPFirstSemester
{
    class PluckedBird : BirdForSale
    {
        public PluckedBird(BirdForSale birdForSale) : base(birdForSale)
        {

        }

        protected override decimal GetPrice()
        {
            return 50;
        }

        protected override string GetInfo()
        {
            return " + общипанная";
        }
    }
}