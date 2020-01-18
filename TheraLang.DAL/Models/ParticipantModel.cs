using TheraLang.DAL.Enums;

namespace TheraLang.DAL.Models
{
    public class ParticipantModel
    {
        public int Id { get; set; }

        public MemberRole Role { get; set; }

        public ProjectParticipationStatus Status { get; set; }

        public int ProjectId { get; set; }
        
        public string UserName { get; set; }
        
        public string UserEmail { get; set; }

    }
}