using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;
using TheraLang.Tests.Builders;

namespace TheraLang.Tests.DataBuilders.ResourcesBuilders
{
    public class RoleTestBuilder : IDataBuilder<Role>
    {
        private Role _role;
        public RoleTestBuilder()
        {
            _role = new Role();
        }

        public RoleTestBuilder RoleAdmin()
        {
            _role.Name = "Admin";
            _role.Id = new Guid("F4CBFF0F-4BC0-42A4-9738-8D9F9BB734BA");
            return this;
        }

        public RoleTestBuilder RoleMember()
        {
            _role.Name = "Member";
            _role.Id = new Guid("50245AB3-6770-4269-AC26-30A942116A70");
            return this;
        }

        public RoleTestBuilder RoleGuest()
        {
            _role.Name = "Guest";
            _role.Id = new Guid("7E9B3674-E720-4D50-939B-93CE8E8B1C44");
            return this;
        }

        public Role Build()
        {
            return _role;
        }
    }
}
