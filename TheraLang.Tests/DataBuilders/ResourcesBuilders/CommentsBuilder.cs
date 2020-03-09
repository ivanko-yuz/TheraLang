using System;
using TheraLang.DAL.Entities;

namespace TheraLang.Tests.DataBuilders.ResoursesBuilders
{
    class CommentsBuilder : IDataBuilder<NewsComment>
    {
        private NewsComment _comment;

        public CommentsBuilder()
        {
            _comment = new NewsComment();
        }

        public NewsComment Build()
        {
            return _comment;
        }

        public CommentsBuilder WithDefaultText()
        {
            _comment.Text = "Text";
            return this;
        }

        public CommentsBuilder WithId(int id)
        {
            _comment.Id = id;
            return this;
        }

        public CommentsBuilder WithText(string text)
        {
            _comment.Text = text;
            return this;
        }

        public CommentsBuilder WithNewsId(int newsId)
        {
            _comment.NewsId = newsId;
            return this;
        }

        public CommentsBuilder WithAuthorId(Guid id)
        {
            _comment.CreatedById = id;
            return this;
        }
    }
}