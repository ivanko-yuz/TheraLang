//using Microsoft.EntityFrameworkCore;
//using Microsoft.EntityFrameworkCore.Design;
//using Microsoft.Extensions.Configuration;

//namespace MvcWeb.Db
//{
//    public class IttmmContextFactory : IDesignTimeDbContextFactory<IttmmDbContext>
//    {
//        public IttmmDbContext CreateDbContext(string[] args)
//        {
//            var configuration = new ConfigurationBuilder()
//                .AddJsonFile("appsettings.json")
//                .Build();

//            var optionsBuilder = new DbContextOptionsBuilder<IttmmDbContext>();
//            optionsBuilder.UseSqlServer("DefaultConnection");

//            return new IttmmDbContext(optionsBuilder.Options);
//        }
//    }
//}
