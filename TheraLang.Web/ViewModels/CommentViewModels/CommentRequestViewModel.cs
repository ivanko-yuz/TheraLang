namespace TheraLang.Web.ViewModels.CommentViewModels
{
    public class CommentRequestViewModel
    {
        public string Text { get; set; }
        public int NewsId { get; set; }
        public int? AnsweredCommentId { get; set; }
    }
}
