using System;
using System.Collections.Generic;
using System.Text;

namespace Common
{
    public class PaginationParams
    {
        public const int MaxPageSize = 20;
        
        private int _pageNumber = 1;
        private int _pageSize = MaxPageSize;


        public int PageNumber
        {
            get => _pageNumber;
            set
            {
                _pageNumber = value > 1 ? value : 1;
            }
        }

        public int PageSize
        {
            get => _pageSize;
            set
            {
                _pageSize = value > 0 ? (value < MaxPageSize? value : MaxPageSize) : 0;
            }
        }
    }
}
