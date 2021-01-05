using System;

namespace backend.Models
{
    public class Post
    {
        public DateTime Date { get; set; }
        public int Id {get;set;}
        public string Summary { get; set; }
        public string Category {get;set;}
        public string Body {get;set;}
        public string Title {get;set;}
    }
}
