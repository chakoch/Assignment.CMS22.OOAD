using Assignment.CMS22.OOAD.Contexts;
using Assignment.CMS22.OOAD.Factories;
using Assignment.CMS22.OOAD.Models;
using Assignment.CMS22.OOAD.Models.DTOs;
using Assignment.CMS22.OOAD.Models.Entities;
using Assignment.CMS22.OOAD.Repositories;
using Microsoft.AspNetCore.Mvc;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Assignment.CMS22.OOAD.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ArticlesController : ControllerBase
    {
        private readonly ArticleRepository _articleRepo;

        public ArticlesController(ArticleRepository articleRepo)
        {
            _articleRepo = articleRepo;
        }

        [HttpPost]
        public async Task<IActionResult> Create(ArticleRequest request)
        {
            if(ModelState.IsValid)
            {
                ArticleResponse response = await _articleRepo.CreateAsync(request);
                if (response != null)
                    return Created("", response);
            }

            return BadRequest();
        }

        [HttpPut("{id}")]
        public async Task<IActionResult> Update(Guid id, ArticleRequest request)
        {
            var entity = await _articleRepo.GetAsync(x => x.Id == id);
            if (entity == null)
            {
                return NotFound();
            }

            entity.Title = request.Title;
            entity.Content = request.Content;
            entity.Author = request.Author;

            await _articleRepo.UpdateAsync(entity);

            return NoContent();
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> Get(Guid id)
        {
            var entity = await _articleRepo.GetAsync(x => x.Id == id);
            if (entity != null)
            {
                var response = ArticleFactory.CreateArticleRespons();
                return Ok(response);
            }

            return NotFound();
        }

        [HttpGet]
        public async Task<IActionResult> GetAll()
        {
            var articles = await _articleRepo.GetAllAsync();
            var response = articles.Select(x => ArticleFactory.CreateArticleRespons());
            return Ok(response);
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> Delete(Guid id)
        {
            var entity = await _articleRepo.GetAsync(x => x.Id == id);

            if (entity != null)
            {
                await _articleRepo.DeleteAsync(id);
            }

            return NotFound();
        }

    }
}
