﻿using CleanMovie.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CleanMovie.Application.MovieApplication
{
    public class MovieService : IMovieService
    {
        //Constructor Dependency Injection
        private readonly IMovieRepository _movieRepository;

        public MovieService(IMovieRepository movieRepository)
        {
            _movieRepository = movieRepository;
        }

        public Movie CreateMovie(Movie movie)
        {
            _movieRepository.CreateMovie(movie);

            return movie;
        }

        public List<Movie> GetAllMovies()
        {
            var movies = _movieRepository.GetAllMovies();

            return movies;
        }
    }
}
