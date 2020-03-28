using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using TheraLang.BLL.DataTransferObjects;
using TheraLang.BLL.Interfaces;
using TheraLang.Web.ViewModels;

namespace TheraLang.Web.Controllers
{
    [Authorize]
    [Route("api/memberFee")]
    [ApiController]
    public class MemberFeeController : ControllerBase
    {
        private readonly IMemberFeeService _memberFeeService;

        public MemberFeeController(IMemberFeeService memberFeeService)
        {
            _memberFeeService = memberFeeService;
        }

        // GET: api/memberFee
        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var mapper =
                new MapperConfiguration(cfg => cfg.CreateMap<MemberFeeDto, MemberFeeViewModel>()).CreateMapper();

            var memberFeeDtos = await _memberFeeService.GetMemberFeesAsync();

            if (memberFeeDtos == null)
            {
                return NotFound();
            }

            var memberFeeModels = mapper.Map<List<MemberFeeViewModel>>(memberFeeDtos);
            return Ok(memberFeeModels);
        }

        // POST: api/memberFee
        [HttpPost]
        public async Task<IActionResult> CreateMemberFee([FromBody] MemberFeeViewModel memberFeeModel)
        {
            if (memberFeeModel == null)
            {
                throw new ArgumentNullException($"{nameof(memberFeeModel)} can not be null");
            }

            var mapper =
                new MapperConfiguration(cfg => cfg.CreateMap<MemberFeeViewModel, MemberFeeDto>()).CreateMapper();
            var memberFeeDto = mapper.Map<MemberFeeViewModel, MemberFeeDto>(memberFeeModel);

            await _memberFeeService.AddAsync(memberFeeDto);
            return Ok();
        }

        // DELETE: api/memberFee/5
        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(int id)
        {
            try
            {
                await _memberFeeService.DeleteAsync(id);
            }

            catch (ArgumentException)
            {
                return NotFound();
            }

            return Ok();
        }
    }
}