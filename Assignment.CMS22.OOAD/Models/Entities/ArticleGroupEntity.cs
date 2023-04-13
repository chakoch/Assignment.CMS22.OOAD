using Assignment.CMS22.OOAD.Factories;
using Assignment.CMS22.OOAD.Models.DTOs;

namespace Assignment.CMS22.OOAD.Models.Entities
{
    public class ArticleGroupEntity : ArticleGroup
    {
        public int Id { get; set; }
    }

    //public static implicit operator ArticleGroup(ArticleGroupEntity entity)
    //{
    //    var entity = ArticleGroupFactory.Create();

    //    entity.News = entity.News;

    //    return entity;
    //}
}
