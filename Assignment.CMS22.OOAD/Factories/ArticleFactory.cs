using Assignment.CMS22.OOAD.Models.DTOs;
using Assignment.CMS22.OOAD.Models.Entities;

namespace Assignment.CMS22.OOAD.Factories
{
    public class ArticleFactory
    {
        public static ArticleEntity CreateArticleEntity() => new();
        public static ArticleRequest CreateArticleRequest() => new();
        public static ArticleResponse CreateArticleRespons() => new();
    }
}
