using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MvcWeb.TheraLang.Pagination
{
    public class PageVievModel
    {
        public int totalPages { get; private set; }

        public int PageNumber { get; private set; }
        public PageVievModel(int count, int pageNumber, int pageSize)
        {
            PageNumber = pageNumber;
            totalPages = (int)Math.Ceiling(count / (double)pageSize);
        }
        public bool HasPreviousPage
        {
            get
            {
                return (PageNumber > 1);
            }
        }
        public bool HasNextPage
        {
            get
            {
                return (PageNumber < totalPages);
            }
        }

    }
    
}
