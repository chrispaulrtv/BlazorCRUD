using BlazorCRUD.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlazorCRUD.UI.Interfaces
{
    public interface IFilmService
    {
        Task<IEnumerable<Film>> GetAllFilms();

        Task<Film> GetDetails(int Id);

        Task<bool> DeleteFilm(int Id);

        Task<bool> SaveFilm(Film film);


    }
}
