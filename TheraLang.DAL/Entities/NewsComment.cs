namespace TheraLang.DAL.Entities
{
    public class NewsComment : BaseEntity
    {
        public string Text { get; set; }
        public virtual User Author { get; set; }
        public int NewsId { get; set; }
        public News News { get; set; }
    }
}
