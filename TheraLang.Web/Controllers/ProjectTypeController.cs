﻿using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Entities;
using TheraLang.Web.Services;

namespace TheraLang.Web.Controllers
{
    [ApiController]
    [Route("api/projectTypes")]
    public class ProjectTypeController : ControllerBase
    {
        private readonly IProjectTypeService _service;
        public ProjectTypeController(IProjectTypeService service)
        {
            _service = service;
        }

<<<<<<< HEAD
=======
        /// <summary>
        /// get all ProjectsTypes
        /// </summary>
        /// <returns>array of ProjectsTypes</returns>
>>>>>>> master
        [HttpGet]
        public IEnumerable<ProjectType> GetAllTypes()
        {
            return _service.GetAllProjectsType();
        }

        /// <summary>
        /// Get ProjectType by id
        /// </summary>
        /// <param name="id"></param>
        /// <returns>selected ProjectType</returns>
        [HttpGet("{id}")]
        public IActionResult GetType(int id)
        {
            if(id == default)
            {
                throw new ArgumentException($"{nameof(id)} can not be 0");
            }
            var type = _service.GetProjectTypeById(id);           
            return Ok(type);
        }            
    }
}
