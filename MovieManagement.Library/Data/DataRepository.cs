using MovieManagement.Library.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagement.Library.Data
{
    public class DataRepository : IDataRepository
    {
        private static List<MovieModel> _movie = new()
        {
            new MovieModel {Id = 1, Name = "LOTR", Price = 350m},
            new MovieModel {Id = 2, Name = "Harry Potter", Price = 340m}
        };
        public MovieModel AddMovie(MovieModel movie)
        {
            _movie.Add(movie);
            return movie;
        }

        public List<MovieModel> GetMovies()
        {
            return _movie;
        }
    }
}
