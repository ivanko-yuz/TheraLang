using MockQueryable.Moq;
using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using TheraLang.DAL.Repository;

namespace TheraLang.Tests.Mocks
{
    public class RepositoryMock<T> where T: class
    {
        public Mock<IRepository<T>> Repository;

        public RepositoryMock(List<T> testDB)
        {
            Repository = new Mock<IRepository<T>>();
            Repository.Setup(r => r.GetAll()).Returns(testDB.AsQueryable().BuildMock().Object);
            Repository.Setup(r => r.Get(It.IsAny<Expression<Func<T, bool>>>()))
                      .ReturnsAsync((Expression<Func<T, bool>> predicate) => testDB
                      .AsQueryable()
                      .Where(predicate)
                      .FirstOrDefault());
            Repository.Setup(r => r.Add(It.IsAny<T>()))
                     .Callback((T item) =>
                     {
                         testDB.Add(item);
                     });
            Repository.Setup(r => r.GetAllAsync(It.IsAny<Expression<Func<T, bool>>>()))
                .ReturnsAsync((Expression<Func<T, bool>> predicate) => testDB.AsQueryable()
                .Where((predicate == null ? _ => true : predicate))
                .BuildMock().Object);
        }
    }
}
