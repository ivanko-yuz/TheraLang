using Common.Enums;
using System;
using TheraLang.DAL.Entities;

namespace TheraLang.Tests.DataBuilders.ResourcesBuilders
{
    public class PaymentHistoryTestBuilder : IDataBuilder<PaymentHistory>
    {
        private PaymentHistory _paymentHistory;
        public PaymentHistoryTestBuilder()
        {
            _paymentHistory = new PaymentHistory();
        }

        public PaymentHistoryTestBuilder WithDate(DateTime date)
        {
            _paymentHistory.Date = date;
            return this;
        }

        public PaymentHistoryTestBuilder WithId(Guid id)
        {
            _paymentHistory.Id = id;
            return this;
        }

        public PaymentHistoryTestBuilder WithDescription(PaymentDescription description)
        {
            _paymentHistory.Description = description;
            return this;
        }

        public PaymentHistoryTestBuilder WithSaldo(decimal saldo)
        {
            _paymentHistory.Saldo = saldo;
            return this;
        }

        public PaymentHistoryTestBuilder WithUserId(Guid userId)
        {
            _paymentHistory.UserId = userId;
            return this;
        }

        public PaymentHistoryTestBuilder WithPayer(User payer)
        {
            _paymentHistory.Payer = payer;
            return this;
        }

        public PaymentHistoryTestBuilder WithCurrentBalance(decimal balance)
        {
            _paymentHistory.CurrentBalance = balance;
            return this;
        }

        public PaymentHistoryTestBuilder WithGeneratedPayer(Guid id)
        {
            _paymentHistory.UserId = id;

            _paymentHistory.Payer = new UserTestBuilder()
                .WithDefault()
                .WithId(id)
                .WithDefaultDetails()
                .WithDefaultRole()
                .Build();

            return this;
        }

        public PaymentHistory Build()
        {
            return _paymentHistory;
        }
    }
}
