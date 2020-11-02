namespace OOPFirstSemester
{
    class StandardBirdForSale : BirdForSale
    {
        public StandardBirdForSale()
        {
        }

        protected override decimal GetPrice()
        {
            return 100;
        }

        protected override string GetInfo()
        {
            return "Стандартная птица";
        }
    }
}