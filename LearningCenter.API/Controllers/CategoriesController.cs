using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using AutoMapper;
using LearningCenter.API.Resources;
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
        private IMapper _mapper;
        public CategoriesController(ICategoryDomain categoryDomain, IMapper mapper)
        {
            _categoryDomain = categoryDomain;
            mapper = this._mapper;
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
        public async Task<bool> Post([FromBody] CategoryResource categoryInput)
        {
            //transferimos informacion de una capa a otra
          /*  var category = new Category()
            {
                Name = categoryInput.Name,
                Description = categoryInput.Description
            };*/
          
          //en la variable category ya esta toda la configuracion del mapper ya qu esta
          //inyectada
          //le digo de donde a donde va a ir, va a ser una conversion de categoryResource a una clase tipo Category
          //y voy a obetener los datos de category input
            var category = _mapper.Map<CategoryResource, Category>(categoryInput);
            return await _categoryDomain.createCategory(category);
        }
        
        // PUT: api/Categories/5
        [HttpPut("{id}")]
        public Boolean Put(int id, [FromBody] string value)
        {
            return _categoryDomain.updateCategory(id,value);
        }

        // DELETE: api/Categories/5
        [HttpDelete("{id}")]
        public Boolean Delete(int id)
        {
            return _categoryDomain.deleteCategory(id);
        }
    }
}
