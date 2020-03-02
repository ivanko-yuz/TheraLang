using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.Repository;
using TheraLang.DAL.UnitOfWork;
using Xunit;
using FluentAssertions;
using TheraLang.BLL.DataTransferObjects;

namespace TheraLang.Tests.Services
{
    public class MemberFeeServiceTests
    {
        private List<MemberFee> fakeMemberFees = new List<MemberFee>
        {
            new MemberFee {Id = 1,FeeDate = new DateTime(2020,1,1),FeeAmount = 200 },
            new MemberFee {Id = 2,FeeDate = new DateTime(2020,2,1),FeeAmount = 300 },
            new MemberFee {Id = 3,FeeDate = new DateTime(2020,3,1),FeeAmount = 400 }
        };

        private Mock<IUnitOfWork> mockUnitOfWork;
        private  Mock<IRepository<MemberFee>> mockRepo;

        [Fact]
        public void GetMemberFeesAsync_ShouldReturnAllFees()
        {
            mockUnitOfWork = new Mock<IUnitOfWork>();
            mockRepo = new Mock<IRepository<MemberFee>>();

            mockUnitOfWork.Setup(x => x.Repository<MemberFee>()).Returns(mockRepo.Object);
            mockRepo.Setup(x => x.GetAllAsync(It.IsAny<Expression<Func<MemberFee, bool>>>()))
                .ReturnsAsync((Expression<Func<MemberFee, bool>> expression) => fakeMemberFees);

            MemberFeeService memberFeeService = new MemberFeeService(mockUnitOfWork.Object);
            var result = memberFeeService.GetMemberFeesAsync();

            result.Should().NotBeNull();
            result.Result.Count().Should().Be(3);
        }

        [Fact]
        public void DeleteAsync_ShouldDeleteOneFee()
        {
            mockUnitOfWork = new Mock<IUnitOfWork>();
            mockRepo = new Mock<IRepository<MemberFee>>();

            mockUnitOfWork.Setup(x => x.Repository<MemberFee>()).Returns(mockRepo.Object);
            mockUnitOfWork.Setup(x => x.SaveChangesAsync()).Verifiable();
            mockRepo.Setup(x => x.Get(It.IsAny<Expression<Func<MemberFee, bool>>>()))
                .ReturnsAsync((Expression<Func<MemberFee, bool>> expression) => fakeMemberFees
                .AsQueryable()
                .Where(expression)
                .FirstOrDefault());

            mockRepo.Setup(x => x.Remove(It.IsAny<MemberFee>())).Verifiable();
            MemberFeeService memberFeeService = new MemberFeeService(mockUnitOfWork.Object);

            var result = memberFeeService.DeleteAsync(1);

            mockRepo.Verify(x => x.Remove(It.IsAny<MemberFee>()), Times.Once());
            mockUnitOfWork.Verify(x => x.SaveChangesAsync(), Times.Once());


        }

        [Fact]
        public void DeleteAsync_ShouldThrowArgumentNullException()
        {
            mockUnitOfWork = new Mock<IUnitOfWork>();
            mockRepo = new Mock<IRepository<MemberFee>>();

            mockUnitOfWork.Setup(x => x.Repository<MemberFee>()).Returns(mockRepo.Object);
            mockRepo.Setup(x => x.Get(It.IsAny<Expression<Func<MemberFee, bool>>>())).ReturnsAsync(() => null);
            MemberFeeService memberFeeService = new MemberFeeService(mockUnitOfWork.Object);

            var act = Assert.Throw<ArgumentNullException>(async () => await memberFeeService.DeleteAsync(4));

            act.Should().Throw<ArgumentNullException>();
        }

        [Fact]
        public void AddAsync_ShouldAddMemberFee() 
        {
            mockUnitOfWork = new Mock<IUnitOfWork>();
            mockRepo = new Mock<IRepository<MemberFee>>();

            mockUnitOfWork.Setup(x => x.Repository<MemberFee>()).Returns(mockRepo.Object);
            mockUnitOfWork.Setup(x => x.SaveChangesAsync()).Verifiable();
            mockRepo.Setup(x => x.Add(It.IsAny<MemberFee>())).Verifiable();

            MemberFeeService memberFeeService = new MemberFeeService(mockUnitOfWork.Object);

            var result = memberFeeService.AddAsync(new MemberFeeDto());

            mockRepo.Verify(x => x.Add(It.IsAny<MemberFee>()), Times.Once());
            mockUnitOfWork.Verify(x => x.SaveChangesAsync(), Times.Once());
        }
        [Fact]
        public void AddAsync_ShouldThrowException()
        {
            mockUnitOfWork = new Mock<IUnitOfWork>();
            mockRepo = new Mock<IRepository<MemberFee>>();

            mockUnitOfWork.Setup(x => x.SaveChangesAsync()).Verifiable();
            mockUnitOfWork.Setup(x => x.Repository<MemberFee>()).Returns(mockRepo.Object);
            mockRepo.Setup(x => x.Add(It.IsAny<MemberFee>())).Throws<Exception>();

            MemberFeeService memberFeeService = new MemberFeeService(mockUnitOfWork.Object);

            Func<Task> act = async () => await memberFeeService.AddAsync(new MemberFeeDto());

            mockUnitOfWork.Verify(x => x.SaveChangesAsync(), Times.Never());
            act.Should().Throw<Exception>();
        }
    }
}
