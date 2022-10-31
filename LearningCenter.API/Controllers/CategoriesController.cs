using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using LearningCenter.Domain;
using LearningCenter.Infraestructure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace LearningCenter.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private ICategoryDomain _categoryDomain;
        public CategoriesController(ICategoryDomain categoryDomain)
        {
            _categoryDomain = categoryDomain;
        }
        
        
        // GET: api/Categories
        [HttpGet]
        [ProducesResponseType(typeof(List<string>),200)]
        public List<Category> Get()
        {
            return _categoryDomain.getAll();
        }

        // GET: api/Categories/5
        [HttpGet("{id}", Name = "Get")]
        public Category Get(int id)
        {
            return _categoryDomain.getCategoryById(id);
        }

        // POST: api/Categories
        [HttpPost]
        [ProducesResponseType(typeof(Boolean),201)]
        [ProducesResponseType(typeof(List<string>),400)]
        [ProducesResponseType(500)]
        public Boolean Post([FromBody] string value)
        {
            return _categoryDomain.createCategory(value);
        }

        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public Boolean Put(int id, [FromBody] string value)
        {
            return _categoryDomain.updateCategory(id,value);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
