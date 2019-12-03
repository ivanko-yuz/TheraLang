namespace TheraLang.DLL.Entities
{
    public class ResourceProject
    {
        public int Id { get; set; }

        public int ResourceId { get; set; }

        public virtual Resource Resource { get; set; }

        public int ProjectId { get; set; }

        public virtual Project Project { get; set; }
    }
}
