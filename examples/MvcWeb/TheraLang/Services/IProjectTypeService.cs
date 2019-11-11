using MvcWeb.TheraLang.Entities;
using System.Collections.Generic;

namespace MvcWeb.TheraLang.Services
{
    public interface IProjectTypeService
    {
        IEnumerable<ProjectType> GetAllProjectsType();

        ProjectType GetProjectTypeById(int id);
    }
}
