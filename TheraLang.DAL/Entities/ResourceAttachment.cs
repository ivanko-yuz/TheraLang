namespace TheraLang.DAL.Entities
{
    public class ResourceAttachment 
    {
        public int Id { get; set; }

        public int ResourceId { get; set; }

        public string FileName { get; set; }

        public string Path { get; set; }

        public virtual Resource  Resource {get; set;}
    }
}
