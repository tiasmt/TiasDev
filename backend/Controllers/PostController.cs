using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace backend.Controllers
{
    [ApiController]
    [Route("rest/api/latest/posts")]
    public class PostController : ControllerBase
    {
        private static readonly Post[] _posts = new Post[] {
            new Post{Body = "This is my first post", Title = "First Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my first post"},
            new Post{Body = "This is my second post", Title = "Second Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my second post"},
            new Post{Body = "This is my third post", Title = "Third Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my third post"},
            new Post{Body = "This is my forth post", Title = "Forth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my forth post"},
            new Post{Body = "This is my fifth post", Title = "Fifth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my fifth post"},
            new Post{Body = "This is my sixth post", Title = "Sixth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my sixth post"},
            new Post{Body = "This is my seventh post", Title = "Seventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my seventh post"},
            new Post{Body = "This is my eight post", Title = "Eight Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my eight post"},
            new Post{Body = "This is my ninth post", Title = "Ninth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my ninth post"},
            new Post{Body = "This is my tenth post", Title = "Tenth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my tenth post"},
            new Post{Body = "This is my eleventh post", Title = "Eleventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my eleventh post"},
            new Post{Body = "This is my twelfth post", Title = "Twelfth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my twelfth post"},
        };
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public IEnumerable<Post> GetAll()
        {
            return _posts;
        }
    }
}
