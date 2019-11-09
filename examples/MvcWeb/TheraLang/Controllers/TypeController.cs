using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MvcWeb.TheraLang.Entities;
using MvcWeb.TheraLang.UnitOfWork;

// For more information on enabling MVC for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace MvcWeb.TheraLang.Controllers
{
    [ApiController]
    [Route("api/types")]
    public class TypeController : ControllerBase
    {
        // GET: /<controller>/
        private IUnitOfWork uow;
        public TypeController(IUnitOfWork unitOfWork)
        {
            uow = unitOfWork;
        }
        [HttpGet]
        public IEnumerable<TypeProject> GetAllTypes()
        {
            return uow.Repository<TypeProject>().Get().ToList();
        }
        [HttpGet("{id}")]
        public IActionResult GetType(int id)
        {
            var type = GetAllTypes().FirstOrDefault(p => p.Id == id);
            if (type == null)
            {
                throw new  NullReferenceException($"type with {id} not found");
            }
            return Ok(type);
        }
        [HttpPost]
        public IActionResult CreateType(TypeProject type)
        {
            if(type == null)
            {
                throw new NullReferenceException("type can`t be null");
            }
            uow.Repository<TypeProject>().Add(type);
            uow.SaveChangesAsync();
            return Ok(type);
        }
        [HttpPut("{id}")]
        public IActionResult EditType(int id)
        {
            var type = GetAllTypes().FirstOrDefault(p => p.Id == id);
            if (type == null)
            {
                throw new NullReferenceException($"type with id {id} not found");
            }
            uow.Repository<TypeProject>().Update(type);
            uow.SaveChangesAsync();
            return Ok(type);
        }
        [HttpDelete("{id}")]
        public IActionResult DeleteType(int id)
        {
            var type = GetAllTypes().FirstOrDefault(p => p.Id == id);
            if (type == null)
            {
                throw new NullReferenceException($"type with id {id} not found");

            }
            uow.Repository<TypeProject>().Remove(type);
            uow.SaveChangesAsync();
            return Ok(type);
        }
    }
}
