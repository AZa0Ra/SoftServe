using AutoMapper;
using Core.Interfaces;
using Core.Entities;
using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace Core.Services
{
    public class FilmService : IFilmService
    {
        private readonly IRepository<Film> filmRepo;
        private readonly IMapper mapper;

        public FilmService(IRepository<Film> filmRepo, IMapper mapper)
        {
            this.filmRepo = filmRepo;
            this.mapper = mapper;
        }

        public void Create(FilmDTO film)
        {
            filmRepo.Insert(mapper.Map<Film>(film));
            filmRepo.Save();
        }

        public void Delete(int id)
        {
            var film = filmRepo.GetByID(id);

            filmRepo.Delete(film);
            filmRepo.Save();
        }

        public void Edit(FilmDTO film)
        {
            filmRepo.Update(mapper.Map<Film>(film));
            filmRepo.Save();
        }

        public FilmDTO? Get(int id)
        {
            var film = filmRepo.GetByID(id);

         
            return mapper.Map<FilmDTO>(film);
        }

        public IEnumerable<FilmDTO> GetAll()
        {
            var films = filmRepo.GetAll();
            return mapper.Map<IEnumerable<FilmDTO>>(films);
        }

        public IEnumerable<FilmDTO> GetNewReleases()
        {
            var oneMonthAgo = DateTime.Now.AddMonths(-1);
            var films = filmRepo.Get(f => f.ReleaseDate >= oneMonthAgo);
            return mapper.Map<IEnumerable<FilmDTO>>(films);
        }
        public IEnumerable<FilmDTO> GetFilmsByAgeCategory(int ageCategory)
        {
            var films = filmRepo.Get(f => f.AgeRestriction == ageCategory);
            return mapper.Map<IEnumerable<FilmDTO>>(films);
        }
    }
}
