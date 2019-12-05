﻿using System;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using TheraLang.DLL.Services;
using System.Collections.Generic;
using TheraLang.DLL.Entities;

namespace TheraLang.Web.Controllers
{
    [Route("api/category")]
    [ApiController]
    public class CategoryController : ControllerBase
    {
        public CategoryController(IResourceCategoryService service)
        {
            _service = service;
        }

        private readonly IResourceCategoryService _service;

        /// <summary>
        /// change resource category
        /// </summary>
        /// <param name="categoryId">id of category you want to change</param>
        /// <param name="newTypeName">new name of selected category</param>
        /// <returns>wil return just status code</returns>
        [HttpPut]
        [Route("update/{categoryId}/{newType}")]
        public async Task<IActionResult> PutType(int categoryId, string newTypeName)
        {
            if (categoryId == default)
            {
                throw new ArgumentException($"{nameof(categoryId)} can not be 0");
            }
            if (newTypeName == null)
            {
                throw new ArgumentException($"{nameof(newTypeName)} can not be null");
            }
            await _service.ChangeType(categoryId, newTypeName);
            return Ok();
        }

        /// <summary>
        /// get all ResourceCategories
        /// </summary>
        /// <returns>array of ResourceCategories</returns>
        [HttpGet]
        [Route("get")]
        public IEnumerable<ResourceCategory> GetAll()
        {
            IEnumerable<ResourceCategory> categories = _service.GetAllCategories();
            return categories;
        }
    }
}