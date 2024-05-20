using Core.DTOs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Core.Interfaces
{
    public interface IFilmService
    {
        IEnumerable<FilmDTO> GetAll();
        FilmDTO? Get(int id);
        IEnumerable<FilmDTO> GetNewReleases();
        public IEnumerable<FilmDTO> GetFilmsByAgeCategory(int ageCategory);
        void Create(FilmDTO film);
        void Edit(FilmDTO film);
        void Delete(int id);
    }
}
