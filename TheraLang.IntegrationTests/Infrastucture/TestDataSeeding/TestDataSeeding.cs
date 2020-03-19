using System;
using System.Collections.Generic;
using System.Text;
using TheraLang.DAL;
using TheraLang.IntegrationTests.Infrastucture.TestDataSeeding.EntitiesSeeding;

namespace TheraLang.IntegrationTests.Infrastucture.TestDataSeeding
{
    class TestDataSeeding
    {
        public static void InitializeDbForTests(IttmmDbContext db)
        {
            //Adding seeding for entities
            db.News.AddRange(NewsSeeding.GetSeedingNews());

            db.SaveChanges();
        }

        public static void ReinitializeDbForTests(IttmmDbContext db)
        {
            //TODO Check
            db.RemoveRange(db);
            InitializeDbForTests(db);
        }
    }
}
