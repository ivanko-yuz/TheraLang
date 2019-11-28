/*
 * Copyright (c) 2019 Håkan Edling
 *
 * This software may be modified and distributed under the terms
 * of the MIT license.  See the LICENSE file for details.
 *
 * http://github.com/tidyui/coreweb
 *
 */

using Piranha.AttributeBuilder;
using Piranha.Extend;
using Piranha.Models;
using Piranha.Extend.Fields;

namespace TheraLangWeb.Models
{
    /// <summary>
    /// Basic page with main content in markdown.
    /// </summary>
    [SiteType(Title = "Standard Site")]
    public class StandardSite : SiteContent<StandardSite>
    {
        [Region]
        public HtmlField Footer { get; set; }
    }
}
