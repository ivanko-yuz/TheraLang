﻿using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects.Donations;

namespace TheraLang.BLL.Interfaces
{
    public interface ILiqPayService
    {
        Task<LiqPayCheckoutDto> GetLiqPayCheckoutModel(LiqPayCheckoutModelRequestDto liqPayCheckoutModelRequest);
    }
}