using Core.DTOs;
using Core.Interfaces;
using Core.Services;
using Infrastructure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Net;
using System.Numerics;
namespace Cinema_API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FilmController : ControllerBase
    {
        private readonly IFilmService filmService;

        public FilmController(IFilmService filmService)
        {
            this.filmService = filmService;
        }

        [HttpGet("collection")]         
        public IActionResult GetAll()
        {
            return Ok(filmService.GetAll());
        }


        [HttpGet("{id}")]
        public IActionResult Get([FromRoute] int id) 
        {
            return Ok(filmService.Get(id));
        }

        [HttpGet("new-releases")]
        public IActionResult GetNewReleases()
        {
            var films = filmService.GetNewReleases();
            return Ok(films);
        }

        [HttpGet("by-age-category")]
        public IActionResult GetFilmsByAgeCategory([FromQuery] int ageCategory)
        {
            var films = filmService.GetFilmsByAgeCategory(ageCategory);
            return Ok(films);
        }

        [HttpPost]
        [Authorize(Roles = "Admin")]
        public IActionResult Create([FromBody] FilmDTO film) 
        {
            if (!ModelState.IsValid) return BadRequest();

            filmService.Create(film);

            return Ok();
        }

        [HttpPut]
        [Authorize(Roles = "Admin")]
        public IActionResult Edit([FromBody] FilmDTO film)
        {
            if (!ModelState.IsValid) return BadRequest();

            filmService.Edit(film);

            return Ok();
        }

        [HttpDelete("{id}")]
        [Authorize(Roles = "Admin")]
        public IActionResult Delete([FromRoute] int id)
        {
            filmService.Delete(id);
            return Ok();
        }
    }
}
