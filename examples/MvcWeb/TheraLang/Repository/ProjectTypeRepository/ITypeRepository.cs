using MvcWeb.TheraLang.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Repository.ProjectTypeRepository
{
    public interface ITypeRepository
    {
        Task SortingById();
        Task SortingByName();
    }
}
