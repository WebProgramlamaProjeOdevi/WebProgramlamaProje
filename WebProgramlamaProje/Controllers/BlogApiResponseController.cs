using Microsoft.AspNetCore.Mvc;
using Newtonsoft.Json;
using NuGet.Protocol.Plugins;
using System.Text;
using WebProgramlamaProje.Entity;

namespace WebProgramlamaProje.Controllers
{
    public class BlogApiResponseController : Controller
    {
        HttpClientHandler _ClientHandler=new HttpClientHandler();  

        Blog _blogs =new Blog();  
        List<Blog> _blogsList = new List<Blog>();
        public BlogApiResponseController()
        {
            _ClientHandler.ServerCertificateCustomValidationCallback = (sender, cert, chain, sslPolicyErrors) => { return true; };
        }
        public IActionResult Index()
        {
            return View();
        }
        [HttpGet]
        public async Task<List<Blog>> GetAllBlogs()
        {
            _blogsList = new List <Blog>();
            using (var httpclient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpclient.GetAsync("https://localhost:7191/api/BlogsApi"))
                {
                   string apiresponse =await response.Content.ReadAsStringAsync();
                    _blogsList = JsonConvert.DeserializeObject<List<Blog>>(apiresponse);
                }
            }
            return _blogsList;
        }
        [HttpGet]
        public async Task<Blog> GetById(int blogid)
        {
            _blogs = new Blog();
            using (var httpclient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpclient.GetAsync("https://localhost:7191/api/BlogsApi/" + blogid))
                {
                    string apiresponse = await response.Content.ReadAsStringAsync();
                    _blogs = JsonConvert.DeserializeObject<Blog>(apiresponse);
                }
            }
            return _blogs;
        }
        [HttpPost]
        public async Task<Blog> Post(Blog blog)
        {
            _blogs = new Blog();
            using (var httpclient = new HttpClient(_ClientHandler))
            {
                StringContent content = new StringContent(JsonConvert.SerializeObject(blog),Encoding.UTF8,"application/json");

                using (var response = await httpclient.PostAsync("https://localhost:7191/api/BlogsApi",content))
                {
                    string apiresponse = await response.Content.ReadAsStringAsync();
                    _blogs = JsonConvert.DeserializeObject<Blog>(apiresponse);
                }
            }
            return _blogs;
        }

        [HttpDelete]
        public async Task<string> Delete(int blogid)
        {
            string message = "";
            using (var httpclient = new HttpClient(_ClientHandler))
            {
                using (var response = await httpclient.DeleteAsync("https://localhost:7191/api/BlogsApi/" + blogid))
                {
                    message = await response.Content.ReadAsStringAsync();
                   
                }
            }
            return message;
        }
    }
}
