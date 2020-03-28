using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.DAL.Entities;
using TheraLang.DAL.UnitOfWork;

namespace TheraLang.BLL.Services
{
    public class MemberFeeService : IMemberFeeService
    {
        private readonly IUnitOfWork _unitOfWork;

        public MemberFeeService(IUnitOfWork unitOfWork)
        {
            _unitOfWork = unitOfWork;
        }

        public async Task<IEnumerable<MemberFeeDto>> GetMemberFeesAsync()
        {
            var memberFees = await _unitOfWork.Repository<MemberFee>().GetAllAsync();

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
                        $"Error while deleting member fee. Fee with {nameof(id)}={id} not found");
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
                if (memberFeeDto == null)
                {
                    throw new NullReferenceException(
                        $"{nameof(MemberFeeDto)} cannot be null");
                }

                var minDate = GetMemberFeesAsync().Result.Last().FeeDate.AddMonths(1);
                if (memberFeeDto.FeeDate <= minDate)
                {
                    throw new Exception(
                        $"Cannot add new {nameof(MemberFee)}.");
                }
                var newDate = new DateTime(memberFeeDto.FeeDate.Year, memberFeeDto.FeeDate.Month, 1);
                var mapper = new MapperConfiguration(cfg => cfg.CreateMap<MemberFeeDto, MemberFee>()
                .ForMember(p => p.FeeDate,opt => opt.MapFrom(n=> newDate)))
                    .CreateMapper();

                var memberFee = mapper.Map<MemberFeeDto, MemberFee>(memberFeeDto);

                _unitOfWork.Repository<MemberFee>().Add(memberFee);
                await _unitOfWork.SaveChangesAsync();
            }
            catch (NullReferenceException)
            {
                throw;
            }
            catch (Exception ex)
            {
                ex.Data[nameof(MemberFee)] = memberFeeDto;
                throw;
            }
        }
    }
}