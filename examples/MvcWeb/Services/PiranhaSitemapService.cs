using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Piranha;
using Piranha.Models;

namespace MvcWeb.Services
{
    public class PiranhaSitemapService
    {
        private IApi Api { get; }

        public PiranhaSitemapService(IApi api)
        {
            Api = api;
        }
        
        public async Task<Sitemap> GetSiteMap(Guid? id = null)
        {
            var siteMap = await Api.Sites.GetSitemapAsync(id);

            foreach (var siteMapItem in siteMap)
            {
                await siteMapItem.RecursiveAdd(GetChildSitemapItems);
            }

            return siteMap;
        }
        
        private async Task<IEnumerable<SitemapItem>> GetChildSitemapItems(SitemapItem sitemapItem)
        {
            var items = new List<SitemapItem>();
            
             (await GetChildPages(sitemapItem?.Id))
                .PublishedOnly()
                .ToSitemap(sitemapItem?.Id, sitemapItem?.Level ?? 0)
                .AddRangeToList(items);
                    
            if (sitemapItem != null)
            {
                (await GetChildPosts(sitemapItem.Id))
                    .PublishedOnly()
                    .ToSitemap(sitemapItem.Id, sitemapItem.Level)
                    .AddRangeToList(items);
            }
            
            return items;
        }
        
        private Task<IEnumerable<DynamicPage>> GetChildPages(Guid? parentId)
        {
            return Api.Pages.GetAllAsync(parentId);
        }
        
        private Task<IEnumerable<DynamicPost>> GetChildPosts(Guid parentId)
        {
            return Api.Posts.GetAllAsync(parentId);
        }
    }
    
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
    }
}