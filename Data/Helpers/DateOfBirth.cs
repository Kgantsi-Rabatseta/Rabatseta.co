using System;

namespace Data.Helpers
{
    public class DateOfBirth
    {
        private readonly int _yearOfBirth;
        private readonly int _monthOfBirth;
        private readonly int _dayOfBirth;

        public DateOfBirth(string idNumber)
        {
            var idnyear =Convert.ToInt32("19"+idNumber.Substring(0,2));
            var idoyear = Convert.ToInt32("20" + idNumber.Substring(0, 2));
            _yearOfBirth = idoyear - DateTime.Now.Year > 0? idnyear:idoyear;
            _monthOfBirth = Convert.ToInt32(idNumber.Substring(2, 2));
            _dayOfBirth = Convert.ToInt32(idNumber.Substring(4, 2));
        }

        public int YearOfBirth => _yearOfBirth;
        public int MonthOfBirth => _monthOfBirth;
        public int DayOfBirth => _dayOfBirth;

        public string Month => new DateTime(_yearOfBirth,_monthOfBirth,_dayOfBirth).ToString("MMMM");

        public override string ToString()
        {
            return _yearOfBirth + "-" + _monthOfBirth.ToString().PadLeft(2,'0') + "-" + _dayOfBirth.ToString().PadLeft(2,'0');
        }
    }
}