using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using MvcWeb.Helpers;
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
}