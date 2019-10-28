namespace MvcWeb.Db.Entities
{
    public class Project
    {
        public int Id { get; set; }

        public string Type { get; set; }

        public string Name { get; set; }
     
        /// Need to add foreign key and navigation property.
    }
}
