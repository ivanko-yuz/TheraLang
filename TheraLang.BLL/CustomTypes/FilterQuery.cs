using Common.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.CustomTypes
{
    public class FilterQuery
    {
        IQueryable<Project> _projectsDtos;
        public string Search { get; set; }
        public bool MyProjects { get; set; }
        public bool SortByDateAsc { get; set; }
        public bool SortByDateDesc { get; set; }
        public bool SortByDaysLeft { get; set; }
        public AuthUser User { get; set; }

       
        private void SearchFilter()
        {
            if (Search != null && Search != "")
            {
                _projectsDtos = _projectsDtos.Where(p => p.Name.Contains(Search));
            }
        }
        private void MyProjectsFilter()
        {
            if (MyProjects)
            {
                var prParticipants = _projectsDtos.Select(p => p.ProjectParticipations
                .Where(pr => pr.Role == MemberRole.ProjectOwner)
                .Where(pr => pr.User.Id == User.Id));
                var prs = prParticipants.Select(p => p.Select(pr => pr.Project));
                _projectsDtos = prs.Select(p => p.FirstOrDefault());
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
