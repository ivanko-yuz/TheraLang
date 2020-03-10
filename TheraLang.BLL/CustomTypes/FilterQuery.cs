using Common.Enums;
using System;
using System.Linq;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.CustomTypes
{
    public class FilterQuery
    {
       private  IQueryable<Project> _projectsDtos;
        public string Search { get; set; }
        public bool MyProjects { get; set; }
        public bool SortByDateAsc { get; set; }
        public bool SortByDateDesc { get; set; }
        public bool SortByDaysLeft { get; set; }
        public AuthUser User { get; set; }
       
        private void SearchFilter()
        {
            if (!string.IsNullOrEmpty(Search))
            {
                _projectsDtos = _projectsDtos.Where(p => p.Name.Contains(Search));
            }
        }
        private void MyProjectsFilter()
        {
            if (MyProjects)
            {
                _projectsDtos = _projectsDtos.Where(p => p.OwnerId == User.Id);
            }
        }
        private void SortByDaysLeftFilter()
        {
            if (SortByDaysLeft)
            {
                _projectsDtos = _projectsDtos.OrderBy(p => p.ProjectEnd.Date - DateTime.Now.Date);
            }
        }
        private void SortByDateFilter()
        {
            if (SortByDateAsc)
            {
                _projectsDtos = _projectsDtos.OrderBy(p => p.ProjectStart);
            }
            else
            {
                if (SortByDateDesc)
                {
                    _projectsDtos = _projectsDtos.OrderByDescending(p => p.ProjectStart);

                }
            }
        }
        public IQueryable<Project> Filter(IQueryable<Project> projectsDtos)
        {
            _projectsDtos = projectsDtos;
            MyProjectsFilter();
            SortByDaysLeftFilter();
            SearchFilter();
            SortByDateFilter();
            return _projectsDtos;
        }
    }
}
