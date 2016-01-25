using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Builders.StringBuilders
{
    public class IdNumberBuilder
    {
        private readonly int _year;
        private readonly int _month;
        private readonly int _day;
        private readonly char _gender;


        public IdNumberBuilder(int year, int month, int day, char gender)
        {
            _year = year;
            _month = month;
            _day = day;
            _gender = gender;
        }

        public string Build()
        {
            return new IdNumebr(_year,_month,_day,_gender).ToString();
        }

        public static string BuildAnIdNumber()
        {
            var year = new Random().Next(1916, 2016);
            var month = new Random().Next(1, 13);
            var day = new Random().Next(1, 29);
            var gender = new Random().Next(0, 9) < 5 ? 'F' : 'M';

            return new IdNumberBuilder(year,month,day,gender).Build();
        }

        public static IList<string> BuildIdNumbers(int numberOfIds)
        {
            IList<string> idNumberList = new List<string>();

            while (numberOfIds > 0)
            {
                idNumberList.Add(BuildAnIdNumber());
                --numberOfIds;
            }
            return idNumberList;
        }
    }

    public class IdNumebr
    {
        private string _idNumber;

        public IdNumebr(int year, int month, int day, char gender)
        {
            var random = new Random();
            _idNumber = string.Concat(
                year.ToString().Substring(2,2), month.ToString().PadLeft(2,'0'), day.ToString().PadLeft(2,'0'), gender == 'M' ? random.Next(5, 9) : random.Next(0, 4),
                random.Next(100001, 999999).ToString()
                );
        }

        public override string ToString()
        {
            return _idNumber;
        }
    }
}
