using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebProgramlamaProje.Entity;
using System.Linq;
using Microsoft.CodeAnalysis.FlowAnalysis.DataFlow;
using static System.Reflection.Metadata.BlobBuilder;
using Microsoft.EntityFrameworkCore;

namespace WebProgramlamaProje.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BlogsApiController : ControllerBase
    {
        Context _context = new Context();
        [HttpGet]
        public IEnumerable<Blog> Get()
        {
            return _context.Blogs.ToList();
        }
        [HttpGet("{id}")]
        public IActionResult Get(int id)
        {
            var blog = _context.Blogs.Find(id);
            if (blog == null)
            {
                return NotFound();
            }
            else
            {
                return Ok(blog);
            }

        }
        [HttpPost]
        public IActionResult post([FromBody] Blog blog)
        {
            var _blog = new Blog();
            _blog.AuthorID = blog.AuthorID;
            _blog.ImageAdress = blog.ImageAdress;
            _blog.BlogName = blog.BlogName;
            _blog.CategoryID = blog.CategoryID;
            _blog.Description = blog.Description;
            if (_blog != null)
            {
                _context.Blogs.Add(_blog);
                _context.SaveChanges();
            }
            return Ok(_blog);
        }
        [HttpDelete]
        public IActionResult delete(int id=2)
        { 
            var blog = _context.Blogs.Find(id);
            if (blog != null)
            {
                _context.Blogs.Remove(blog);
                return Ok(blog);

            }
            return BadRequest();

        }
        [HttpGet]
        public IActionResult SearchBlog(string search)
        {
            var blog =(from item in _context.Blogs
                       where item.BlogName.Contains(search) 
                       select item).ToList();
            return Ok(blog);
        }
        [HttpGet("{id}")]
        [Route("api/BlogsApi/find")]
        public IActionResult FindBlogWithId(int Id)
        {
            var blog =_context.Blogs.Where(p=>p.BlogID==Id).FirstOrDefault();
            if (blog != null)
            {
                _context.Blogs.Remove(blog);
                return Ok(blog);

            }
            return BadRequest();
        }
    
    }
}
