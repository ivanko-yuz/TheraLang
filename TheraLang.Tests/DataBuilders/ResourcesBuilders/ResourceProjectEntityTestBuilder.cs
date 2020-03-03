﻿using TheraLang.DAL.Entities;

namespace TheraLang.Tests.DataBuilders.ResourcesBuilders
{
    public class ResourceProjectEntityTestBuilder : IDataBuilder<ResourceProject>
    {
        private readonly ResourceProject _resourceProject;

        public ResourceProjectEntityTestBuilder()
        {
            _resourceProject = new ResourceProject();
        }

        public ResourceProjectEntityTestBuilder WithDefaultValues()
        {
            _resourceProject.Id = DefaultValues.IntId;
            _resourceProject.ProjectId = DefaultValues.IntId;
            _resourceProject.ResourceId = DefaultValues.IntId;
            return this;
        }

        public ResourceProjectEntityTestBuilder WithProjectId(int id)
        {
            _resourceProject.Id = id;
            return this;
        }

        public ResourceProject Build()
        {
            return _resourceProject;
        }
    }
}