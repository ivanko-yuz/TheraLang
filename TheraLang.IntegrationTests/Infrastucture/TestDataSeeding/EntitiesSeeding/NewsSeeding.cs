using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL.Entities;

namespace TheraLang.IntegrationTests.Infrastucture.TestDataSeeding.EntitiesSeeding
{
    class NewsSeeding
    {
        public static List<News> GetSeedingNews()
        {
            var news = new List<News>()
            {
                new News()
                {
                    Id = 1,
                    Title = "Title",
                    Text = "Text",
                    MainImageUrl = "url"
                },
                new News()
                {
                    Id = 2,
                    Title = "Title",
                    Text = "Text",
                    MainImageUrl = "url"
                },
                new News()
                {
                    Id = 3,
                    Title = "Title",
                    Text = "Text",
                    MainImageUrl = "url"
                }
            };
            return news;
        }
    }
}
