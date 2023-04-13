using Assignment.CMS22.OOAD.Factories;
using Assignment.CMS22.OOAD.Models.Entities;

namespace Assignment.CMS22.OOAD.Models.DTOs
{
    public class ArticleRequest : Article
    {

        public static implicit operator ArticleEntity(ArticleRequest request)
        {
            var entity = ArticleFactory.CreateArticleEntity();

            entity.Title = request.Title;
            entity.Content = request.Content;
            entity.Author = request.Author;

            return entity;
        }
    }
}
