using Assignment.CMS22.OOAD.Interfaces;

namespace Assignment.CMS22.OOAD.Models
{
    public class Article : IArticle
    {
        public string Title { get; set; } = null!;
        public string Content { get; set; } = null!;
        public string Author { get; set; } = null!;
    }
}
