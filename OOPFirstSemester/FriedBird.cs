namespace OOPFirstSemester
{
    class FriedBird : BirdForSale
    {
        public FriedBird(BirdForSale birdForSale) : base(birdForSale)
        {

        }

        protected override decimal GetPrice()
        {
            return 10;
        }

        protected override string GetInfo()
        {
            return " + гриль";
        }
    }
}