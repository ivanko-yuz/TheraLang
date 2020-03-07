using System;
using TheraLang.DAL.Entities;

namespace TheraLang.Tests.DataBuilders.ResourcesBuilders
{
    public class UserDetailsTestBuilder : IDataBuilder<UserDetails>
    {
        private UserDetails _userDetails;
        public UserDetailsTestBuilder()
        {
            _userDetails = new UserDetails();
        }

        public UserDetailsTestBuilder WithDefault()
        {
            _userDetails.FirstName = "Anton";
            _userDetails.LastName = "Baran";
            _userDetails.PhoneNumber = "+380961487229";
            _userDetails.ShortInformation = "My name is Anton";
            _userDetails.Age = 27;
            _userDetails.Balance = 0;
            return this;
        }
        /// <summary>
        /// Creats deafultUser only was created UserDetailsId.
        /// In default user field UserDetails is empty.
        /// </summary>
        /// <returns></returns>
        public UserDetailsTestBuilder WithDefaultUser()
        {
            _userDetails.User = new UserTestBuilder()
                .WithId(_userDetails.UserDetailsId)
                .WithDefault()
                .WithDefaultRole()
                .Build();
                return this;
        }

        public UserDetailsTestBuilder WithDefaultUserAndCustomRole(Role role)
        {
            _userDetails.User = new UserTestBuilder()
                .WithId(_userDetails.UserDetailsId)
                .WithDefault()
                .WithRole(role)
                .WithRoleId(role.Id)
                .Build();
            return this;
        }

        public UserDetailsTestBuilder WithUserDetailsId(Guid id)
        {
            _userDetails.UserDetailsId = id;
            return this;
        }

        public UserDetailsTestBuilder WithFirstName(string firstName)
        {
            _userDetails.FirstName = firstName;
            return this;
        }

        public UserDetailsTestBuilder WithLastName(string lastName)
        {
            _userDetails.LastName = lastName;
            return this;
        }

        public UserDetailsTestBuilder WithPhoneNumber(string phone)
        {
            _userDetails.PhoneNumber = phone;
            return this;
        }

        public UserDetailsTestBuilder WithShortInformation(string shortInfo)
        {
            _userDetails.ShortInformation = shortInfo;
            return this;
        }

        public UserDetailsTestBuilder WithImageURl(string url)
        {
            _userDetails.ImageURl = url;
            return this;
        }

        public UserDetailsTestBuilder WithUser(User user)
        {
            _userDetails.User = user;
            return this;
        }

        public UserDetailsTestBuilder WithAge(int age)
        {
            _userDetails.Age = age;
            return this;
        }

        public UserDetailsTestBuilder WithBalance(decimal balance)
        {
            _userDetails.Balance = balance;
            return this;
        }

        public UserDetails Build()
        {
            return _userDetails;
        }
    }
}
