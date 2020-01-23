namespace TheraLang.Web.ViewModels
{
    public class ParticipantViewModel
    {
        public int Id { get; set; }

        public MemberRoleViewModel Role { get; set; }

        public ProjectParticipationStatusViewModel Status { get; set; }

        public int ProjectId { get; set; }
        
        public string UserName { get; set; }
        
        public string UserEmail { get; set; }
    }
}