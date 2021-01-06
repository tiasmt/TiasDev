using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using backend.Models;
using backend.Services;

namespace backend.Controllers
{
    [ApiController]
    [Route("rest/api/latest/posts")]
    public class BlogPostController : ControllerBase
    {
        private static readonly BlogPostOverview[] _postsOverview = new BlogPostOverview[] {
            new BlogPostOverview{Id=1, Title = "First Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my first post"},
            new BlogPostOverview{Id=2, Title = "Second Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my second post"},
            new BlogPostOverview{Id=3, Title = "Third Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my third post"},
            new BlogPostOverview{Id=4, Title = "Forth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my forth post"},
            new BlogPostOverview{Id=5, Title = "Fifth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my fifth post"},
            new BlogPostOverview{Id=6, Title = "Sixth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my sixth post"},
            new BlogPostOverview{Id=7, Title = "Seventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my seventh post"},
            new BlogPostOverview{Id=8, Title = "Eight Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my eight post"},
            new BlogPostOverview{Id=9, Title = "Ninth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my ninth post"},
            new BlogPostOverview{Id=10, Title = "Tenth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my tenth post"},
            new BlogPostOverview{Id=11, Title = "Eleventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my eleventh post"},
            new BlogPostOverview{Id=12, Title = "Twelfth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my twelfth post"},
        };
        private static readonly BlogPost[] _posts = new BlogPost[] {
            new BlogPost{Id=1,Body = @"## header This is my first post", Title = "First Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my first post"},
            new BlogPost{Id=2,Body = "This is my second post", Title = "Second Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my second post"},
            new BlogPost{Id=3,Body = "This is my third post", Title = "Third Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my third post"},
            new BlogPost{Id=4,Body = "This is my forth post", Title = "Forth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my forth post"},
            new BlogPost{Id=5,Body = "This is my fifth post", Title = "Fifth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my fifth post"},
            new BlogPost{Id=6,Body = "This is my sixth post", Title = "Sixth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my sixth post"},
            new BlogPost{Id=7,Body = "This is my seventh post", Title = "Seventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my seventh post"},
            new BlogPost{Id=8,Body = "This is my eight post", Title = "Eight Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my eight post"},
            new BlogPost{Id=9,Body = "This is my ninth post", Title = "Ninth Post", Category = "technology", Date = DateTime.Now, Summary = "Summary of my ninth post"},
            new BlogPost{Id=10,Body = "This is my tenth post", Title = "Tenth Post", Category = "books", Date = DateTime.Now, Summary = "Summary of my tenth post"},
            new BlogPost{Id=11,Body = "This is my eleventh post", Title = "Eleventh Post", Category = "algorithms", Date = DateTime.Now, Summary = "Summary of my eleventh post"},
            new BlogPost{Id=12,Body = "This is my twelfth post", Title = "Twelfth Post", Category = "knowledge", Date = DateTime.Now, Summary = "Summary of my twelfth post"},
        };
        private readonly ILogger<BlogPostController> _logger;
        private IBlogPostService _blogPostService;
        public BlogPostController(ILogger<BlogPostController> logger, IBlogPostService blogPostService)
        {
            _logger = logger;
            _blogPostService = blogPostService;
        }

        [HttpGet("GetAll")]
        public IEnumerable<BlogPostOverview> GetAll()
        {
            // return _postsOverview;
            return _blogPostService.GetAllBlogPosts();
        }

        [HttpGet("{id}")]
        public BlogPost Get(int id)
        {
            // return _posts[id -1];
            return _blogPostService.GetBlogPost(id);
        }
    }
}
