﻿using System.Collections.Generic;
using System.Threading.Tasks;
using MvcWeb.TheraLang.Entities;

namespace MvcWeb.TheraLang.Services
{
    public interface IResourceService
    {
        Task AddResource(Resource resource);

        Task UpdateResource(Resource resource, int updatedById);

        Task RemoveResource(int Id);

        Resource GetResourceById(int Id);
        int GetCountAllResources();
        IEnumerable<Resource> GetAllResources(int pageNumber, int recordsPerPage);
    }
}
