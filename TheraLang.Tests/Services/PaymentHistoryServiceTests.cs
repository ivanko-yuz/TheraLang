
using Common.Enums;
using Moq;
using System;
using System.Collections.Generic;
using TheraLang.BLL.Services;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.Tests.Services
{
    public class PaymentHistoryServiceTests
    {
        private readonly Mock<IUnitOfWork> _unitOfWork;
        private readonly PaymentHistoryService _paymentHistory;
        private readonly List<PaymentHistory> _dbSet;

        private Guid _existedUserGuid = new Guid("2960ECE9-49DA-431E-B5B2-9E9251260707");
        private Guid _fakeUserGuid = new Guid("2960ECE9-49DA-431E-B5B2-9E9251261488");
        public PaymentHistoryServiceTests()
        {

        }
    }
}
    
