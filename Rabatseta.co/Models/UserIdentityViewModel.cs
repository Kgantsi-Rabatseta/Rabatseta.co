using System;
using System.Collections.Generic;
using System.Linq;
using Data.Objects;

namespace Rabatseta.co.Models
{
    public class UserIdentityViewModel
    {
        private readonly IList<SysUser> _users;
        private IList<UserIdTransform> _userData;

        public UserIdentityViewModel(IList<SysUser> users)
        {
            _users = users;
        }

        public int NumberOfUsers => _userData.Count;
        
        public IList<UserIdTransform> UserData
        {
            get
            {
                if (this._userData == null)
                {
                   _userData= _users.Select(u => new UserIdTransform(u)).ToList();
                }
                return _userData;
            }
            set { _userData = value; }
        }
    }

    public class UserIdTransform
    {
        public UserIdTransform(SysUser sysUser)
        {
            SysUserId = sysUser.Id;
            Name = sysUser.Name;
            Surname = sysUser.Surname;
            IdNumber = sysUser.IdNumber;
            EmailAddress = sysUser.EmailAddress;
            var userId = sysUser.UserIdentity;
            Gender = userId.Gender;
            DateOfBirth = userId.DateOfBirth.ToString();
            YearOfBirth = userId.DateOfBirth.YearOfBirth;
            MonthOfBirth = userId.DateOfBirth.Month;
            DayOfBirth = userId.DateOfBirth.DayOfBirth;
            Age = DateTime.Now.Year - YearOfBirth;
        }

        public Guid SysUserId { get; }
        public string DateOfBirth { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string IdNumber { get; set; }
        public string EmailAddress { get; set; }
        public string Gender { get; set; }
        public int YearOfBirth { get; set; }
        public string MonthOfBirth { get; set; }
        public int DayOfBirth { get; set; }
        public int Age{ get; set; }
    }
}