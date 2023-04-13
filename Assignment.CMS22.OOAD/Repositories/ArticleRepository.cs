using Assignment.CMS22.OOAD.Contexts;
using Assignment.CMS22.OOAD.Models.Entities;
using Microsoft.EntityFrameworkCore;
using System.Linq.Expressions;

namespace Assignment.CMS22.OOAD.Repositories
{
    public class ArticleRepository : Repository<ArticleEntity>
    {
        public ArticleRepository(DataContext context) : base(context)
        {
        }
    }
}
