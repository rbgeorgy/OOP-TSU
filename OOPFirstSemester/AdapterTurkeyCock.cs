using System;
namespace OOPFirstSemester
{
    class AdapterTurkeyCock : Duck
    {

        private TurkeyCock _turkeyCock;

        public AdapterTurkeyCock(TurkeyCock turkeyCock)
        {
            _turkeyCock = turkeyCock;
        }

        public override void FPropFunc()
        {
            _turkeyCock.FPropFunc();
        }

        public override void QPropFunc()
        {
            _turkeyCock.CPropFunc();
        }

        public override void SPropFunc()
        {
            _turkeyCock.SPropFunc();
        }

        public override void WPropFunc()
        {
            _turkeyCock.WPropFunc();
        }

        public override void ShowInfo()
        {
            Console.WriteLine("Индюк ставший уткой");
            base.ShowInfo();
        }
    }
}