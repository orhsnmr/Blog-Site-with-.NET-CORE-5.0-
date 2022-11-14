using DataAccessLayer.Concrete;
using DataAccessLayer.Repositories;
using BusinessLayer.Abstract;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using DataAccessLayer.EntityFramework;
using System.Threading.Tasks;
using System.Collections;
using System.Collections.Generic;

namespace NetCore.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ValuesController : ControllerBase
    {
        private readonly GenericRepository<BlogController> blogRepository;
        public ValuesController(GenericRepository<BlogController> BlogRepository)
        {
            blogRepository = BlogRepository;
        }
        //[HttpGet]
        //public async Task<IEnumerable<Blog>> GetBlog()
        //{
        //    return await blogRepository.GetListAll();
        //}
        //[HttpGet("{id}")]
        //public async Task<ActionResult<Blog>> GetBlogs(int ID)
        //{
        //    return await blogRepository.GetListAll(ID);
        //}
    }
}
