using System.Dynamic;
using Data.Helpers;

namespace Data.Objects
{
    public class SysUser:HasId
    {
        public string UserName { get; set; }
        public string Password { get; set; }
        public string Name { get; set;}
        public string Surname { get; set; }
        public string IdNumber { get; set; }

        public SysIdentity UserIdentity =>
            IdNumber != null && IdNumber.Length == 13
                ? new SysIdentity(IdNumber)
                : null;

        public string EmailAddress { get; set; }
    }
}

