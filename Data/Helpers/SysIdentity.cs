using System;

namespace Data.Helpers
{
   public class SysIdentity
    {
        private readonly string _idNumber;
        private readonly int[] _intIdNumber;
       private readonly DateOfBirth _birthDate;
        public SysIdentity(string idNumber)
        {
                _idNumber = idNumber;
                _intIdNumber = new int[13];

                int index = 0;
                foreach (var digit in _idNumber.ToCharArray())
                {
                    _intIdNumber[index++] = Convert.ToInt32(digit.ToString());
                }

                _birthDate = new DateOfBirth(_idNumber);
            
        }

       public DateOfBirth DateOfBirth => _birthDate;

       public string Gender => _intIdNumber[6] < 5 ? "Female" : "Male";

       public string IdNumber => _idNumber;
    }
}
