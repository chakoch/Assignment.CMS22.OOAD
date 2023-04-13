using Assignment.CMS22.OOAD.Factories;
using Assignment.CMS22.OOAD.Models.DTOs;

namespace Assignment.CMS22.OOAD.Models.Entities
{
    public class ArticleEntity : Article
    {
        public Guid Id { get; set; }


        public static implicit operator ArticleResponse(ArticleEntity entity)
        {
            var response = ArticleFactory.CreateArticleEntity();

            response.Id = entity.Id;
            response.Title = entity.Title;
            response.Content = entity.Content;
            response.Author = entity.Author;

            return response;
        }
    }
}
