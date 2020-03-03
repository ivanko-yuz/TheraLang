using System;
using TheraLang.BLL.Interfaces;
using TheraLang.BLL.Services;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.Tests.DataBuilders.ServicesBuilders
{
    public class ResourceServiceBuilder
    {
        private IUnitOfWork _unitOfWork;
        private IFileService _fileService;

        public ResourceServiceBuilder WithUnitOfWork(IUnitOfWork uow)
        {
            _unitOfWork = uow;
            return this;
        }

        public ResourceServiceBuilder WithFileService(IFileService fileService)
        {
            _fileService = fileService;
            return this;
        }

        public ResourceService Buid()
        {
            _ = _unitOfWork ?? throw new ArgumentNullException(nameof(_unitOfWork), "UnitOfWork is not set");
            _ = _fileService ?? throw new ArgumentNullException(nameof(_fileService), "UnitOfWork is not set");
            return new ResourceService(_unitOfWork, _fileService);
        }
    }
}