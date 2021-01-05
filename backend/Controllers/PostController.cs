using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backend.Models;

namespace backend.Controllers
{
    [ApiController]
    [Route("rest/api/latest/posts")]
    public class PostController : ControllerBase
    {
        private static readonly PostOverview[] _postsOverview = new PostOverview[] {
            new PostOverview{Id=1, Title = "First Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my first post"},
            new PostOverview{Id=2, Title = "Second Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my second post"},
            new PostOverview{Id=3, Title = "Third Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my third post"},
            new PostOverview{Id=4, Title = "Forth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my forth post"},
            new PostOverview{Id=5, Title = "Fifth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my fifth post"},
            new PostOverview{Id=6, Title = "Sixth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my sixth post"},
            new PostOverview{Id=7, Title = "Seventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my seventh post"},
            new PostOverview{Id=8, Title = "Eight Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my eight post"},
            new PostOverview{Id=9, Title = "Ninth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my ninth post"},
            new PostOverview{Id=10, Title = "Tenth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my tenth post"},
            new PostOverview{Id=11, Title = "Eleventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my eleventh post"},
            new PostOverview{Id=12, Title = "Twelfth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my twelfth post"},
        };
        private static readonly Post[] _posts = new Post[] {
            new Post{Id=1,Body = "This is my first post", Title = "First Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my first post"},
            new Post{Id=2,Body = "This is my second post", Title = "Second Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my second post"},
            new Post{Id=3,Body = "This is my third post", Title = "Third Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my third post"},
            new Post{Id=4,Body = "This is my forth post", Title = "Forth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my forth post"},
            new Post{Id=5,Body = "This is my fifth post", Title = "Fifth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my fifth post"},
            new Post{Id=6,Body = "This is my sixth post", Title = "Sixth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my sixth post"},
            new Post{Id=7,Body = "This is my seventh post", Title = "Seventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my seventh post"},
            new Post{Id=8,Body = "This is my eight post", Title = "Eight Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my eight post"},
            new Post{Id=9,Body = "This is my ninth post", Title = "Ninth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my ninth post"},
            new Post{Id=10,Body = "This is my tenth post", Title = "Tenth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my tenth post"},
            new Post{Id=11,Body = "This is my eleventh post", Title = "Eleventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my eleventh post"},
            new Post{Id=12,Body = "This is my twelfth post", Title = "Twelfth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my twelfth post"},
        };
        private readonly ILogger<PostController> _logger;

        public PostController(ILogger<PostController> logger)
        {
            _logger = logger;
        }

        [HttpGet("GetAll")]
        public IEnumerable<PostOverview> GetAll()
        {
            return _postsOverview;
        }

        [HttpGet("{id}")]
        public Post Get(int id)
        {
            return _posts[id -1];
        }
    }
}
