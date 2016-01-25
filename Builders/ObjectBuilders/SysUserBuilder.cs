using System;
using System.Collections.Generic;
using System.Linq;
using Builders.StringBuilders;
using Data.Objects;

namespace Builders.ObjectBuilders
{
    public class SysUserBuilder
    {
        private readonly string _emailAddress;
        private readonly Guid _id;
        private readonly string _idNumber;
        private readonly string _name;
        private readonly string _surname;
        private readonly string _userName;


        public SysUserBuilder(Guid id, string name, string surname, string userName, string emailAddress,
            string idNumber)
        {
            _id = id;
            _name = name;
            _surname = surname;
            _userName = userName;
            _emailAddress = emailAddress;
            _idNumber = idNumber;
        }

        public SysUser Build()
        {
            return new SysUser
            {
                Id = _id,
                Name = _name,
                Surname = _surname,
                EmailAddress = _emailAddress,
                IdNumber = _idNumber,
                Password = _name,
                UserName = _userName
            };
        }

        public static SysUser BuildASysUser()
        {
            var id = Guid.NewGuid();
            var name = id + "_name";
            var surname = id + "_surname";
            var emailAddress = id + "@test.com";
            var userName = id + "_userName";
            var idNumber = IdNumberBuilder.BuildAnIdNumber();
            return new SysUserBuilder(
                id, name, surname, userName, emailAddress, idNumber
                ).Build();
        }
        public static SysUser BuildASysUser(string idNumber)
        {
            var id = Guid.NewGuid();
            var name = id + "_name";
            var surname = id + "_surname";
            var emailAddress = id + "@test.com";
            var userName = id + "_userName";
            return new SysUserBuilder(
                id, name, surname, userName, emailAddress, idNumber
                ).Build();
        }
        public static IList<SysUser> BuildSysUsers(int numberOfUsers)
        {
            IList<SysUser> sysUsers =new List<SysUser>();

            while (numberOfUsers > 0)
            {
                var idNumber = IdNumberBuilder.BuildAnIdNumber();
                while(sysUsers.Count >0 && sysUsers.FirstOrDefault(s => s.IdNumber==idNumber)!=null)
                    idNumber = IdNumberBuilder.BuildAnIdNumber();

                var usr = BuildASysUser(idNumber);
                sysUsers.Add(usr);
                numberOfUsers--;
            }
            return sysUsers;
        }
    }
}