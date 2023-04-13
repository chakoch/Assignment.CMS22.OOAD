using Assignment.CMS22.OOAD.Interfaces;

namespace Assignment.CMS22.OOAD.Models
{
    public class ArticleGroup : Article, IArticle
    {
        public virtual string Blog { get; set; } = null!;
        public virtual string News { get; set; } = null!;
        public virtual string Product { get; set; } = null!;
    }
}
