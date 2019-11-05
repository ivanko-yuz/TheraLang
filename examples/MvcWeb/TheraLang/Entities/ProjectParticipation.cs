namespace MvcWeb.TheraLang.Entities
{
    public class ProjectParticipation : BaseEntity
    {
        public virtual User User { get; set; }
        
        public virtual MemberRole Role { get; set; }

        public virtual ProjectParticipationStatus Status { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
