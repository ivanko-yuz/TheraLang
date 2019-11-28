using System;
using System.Linq;
using System.Threading.Tasks;
using TheraLangWeb.TheraLang.DLL.Entities;
using TheraLangWeb.TheraLang.DLL.UnitOfWork;
using System.Collections.Generic;

namespace TheraLangWeb.Services
{
    public class ProjectParticipationService : IProjectParticipationService
    {
        public ProjectParticipationService(IUnitOfWork unit)
        {
            _unitOfWork = unit;
        }

        private readonly IUnitOfWork _unitOfWork;

        public IEnumerable<ProjectParticipation> GetAll()
        {
            return _unitOfWork.Repository<ProjectParticipation>().Get().ToList();
        }

        public async Task CreateRequest(int userId, int projectId)
        {
            try
            {
                ProjectParticipation member = new ProjectParticipation 
                { CreatedById = userId, ProjectId = projectId, UpdatedDateUtc = DateTime.UtcNow };

                await _unitOfWork.Repository<ProjectParticipation>().Add(member);
                await _unitOfWork.SaveChangesAsync();
            }
            catch(Exception ex)
            {
                throw new Exception($"Error when creating request for {nameof(userId)}:{userId}" +
                    $"and {nameof(projectId)}:{projectId}: ", ex);
            }
        }
    }
}
