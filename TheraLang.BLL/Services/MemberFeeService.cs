using AutoMapper;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.UnitOfWork;
using TheraLang.DAL.Entities;

namespace TheraLang.BLL.Services
{
   public class MemberFeeService: IMemberFeeService
    {
        private readonly IUnitOfWork _unitOfWork;
        public MemberFeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }
        public async Task<IEnumerable<MemberFeeDto>> GetMemberFeesAsync()
        {
            var memberFees = await _unitOfWork.Repository<MemberFee>().GetAll()
                .ToListAsync();

            var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MemberFee, MemberFeeDto>()).CreateMapper();
            var memberFeesDto = mapper.Map<IEnumerable<MemberFee>, IEnumerable<MemberFeeDto>>(memberFees);

            return memberFeesDto;
        }
        public async Task DeleteAsync(int id)
        {
            try
            {
                var memberFee = await _unitOfWork.Repository<MemberFee>().Get(x => x.Id == id);
                if (memberFee == null)
                {
                    throw new ArgumentNullException(
                        $"Error while deleting member fee. Fee with id {nameof(id)}={id} not found");
                }

                _unitOfWork.Repository<MemberFee>().Remove(memberFee);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data["Id"] = id;
                throw;
            }
        }
        public async Task AddAsync(MemberFeeDto memberFeeDto)
        {
            try
            {
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MemberFeeDto, MemberFee>())
                    .CreateMapper();
                var memberFee = mapper.Map<MemberFeeDto, MemberFee>(memberFeeDto);

                _unitOfWork.Repository<MemberFee>().Add(memberFee);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (Exception e)
            {
                e.Data[nameof(MemberFee)] = memberFeeDto;
                throw new Exception($"Cannot add new {nameof(MemberFee)}.", e);
            }
        }
    }
    
}
