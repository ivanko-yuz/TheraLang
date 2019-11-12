namespace MvcWeb.TheraLang.Entities
{
    public class ResourceProject
    {
        public int Id { get; set; }
        // If we use ResourceProjectId is it nessesary to use this foreign key and navigation property ?
        public int ResourceId { get; set; }

        public virtual Resource Resource { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
