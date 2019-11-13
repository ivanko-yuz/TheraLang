using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.Extensions.DependencyInjection;
using MvcWeb.Services;
using Piranha.Models;

namespace MvcWeb.Helpers
{
    public static class PiranhaModelHelper
    {
        public static IEnumerable<SitemapItem> ToSitemap(this IEnumerable<RoutedContent> enumerable, Guid? parentId, int parentLevel)
        {
            var sortOrder = 0;
            foreach (var item in enumerable)
            {
                yield return new SitemapItem
                {
                    ParentId = parentId,
                    SortOrder = sortOrder++,
                    Title = item.Title,
                    NavigationTitle = item.Title,
                    PageTypeName = item.TypeId,
                    Permalink = item.Permalink,
                    Published = item.Published,
                    Created = item.Created,
                    LastModified = item.LastModified,
                    Id = item.Id,
                    Level = parentLevel + 1,
                };
            }
        }
        
        public static IEnumerable<RoutedContent> PublishedOnly(this IEnumerable<RoutedContent> content)
        {
            return content.Where(p => p.Published <= DateTime.Now);
        }

        public static void AddRangeToList<TElement>(this IEnumerable<TElement> content, List<TElement> list)
        {
            list.AddRange(content);
        }

        public static async Task RecursiveAdd(this SitemapItem sitemapItem,
            Func<SitemapItem, Task<IEnumerable<SitemapItem>>> getChildren)
        {
            var children = (await getChildren(sitemapItem)).ToArray();
            foreach (var child in children)
            {
                await child.RecursiveAdd(getChildren);
            }
            sitemapItem.Items.AddRange(children);
        }

        public static IServiceCollection RegisterPiranhaWebApiServices(this IServiceCollection services)
        {
            services.AddTransient<PiranhaSitemapService>();
            return services;
        }
    }
}