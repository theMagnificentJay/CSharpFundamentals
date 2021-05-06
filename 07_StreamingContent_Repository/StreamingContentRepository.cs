﻿using _07_StreamingContent_Repository.Content;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _07_StreamingContent_Repository
{
    public class StreamingContentRepository
    {
        private readonly List<StreamingContent> _contentDirectory = new List<StreamingContent>();

        // CRUD methods below

        // Create

        // Content

        public bool AddContentToDirectory(StreamingContent newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Movie
        public bool AddContentToDirectory(Movie newContent)
        {
            int startingCount = _contentDirectory.Count;

            _contentDirectory.Add(newContent);

            bool wasAdded = (_contentDirectory.Count > startingCount) ? true : false;
            return wasAdded;
        }

        // Show

        // Episode

        // Read All

        // Content Read All

        public List<StreamingContent> GetContents()
        {
            return _contentDirectory;
        }

        // Movie Read All
        public List<Movie> GetMovies()
        {
            // initialize empty list
            List<Movie> allMovies = new List<Movie>();
            // Look through our directory
            foreach(StreamingContent content in _contentDirectory)
            {
                // check if object is a Movie
                if (content is Movie)
                {
                    // Load into our list
                    allMovies.Add(content as Movie);
                }
            }
            // Return our list
            return allMovies;
        }

        // Show Read All
        public List<Show> GetShows()
        {
            List<Show> allShows = new List<Show>();
            foreach(StreamingContent content in _contentDirectory)
            {
                // if (content.GetType() == typeof(Show)) same as below
                if (content is Movie)
                {
                    allShows.Add(content as Show);
                }
            }
            return allShows;
        }

        // Episode Read All

        // Get By Title

        // Content

        public StreamingContent GetContentByTitle(string title)
        {
            foreach (StreamingContent content in _contentDirectory)
            {
                if(content.Title.ToLower() == title.ToLower())
                {
                    return content;
                }
            }
            return null;
        }

        // Movie
        public Movie GetMovieByTitle(string title)
        {
            foreach (StreamingContent movie in _contentDirectory)
            {
                                                             // Using is to make sure movie 'is' of class type Movie
                if(movie.Title.ToLower() == title.ToLower() && movie is Movie)
                {
                    // return (Movie)movie; is same as line below, "as" keyword casts type
                    return movie as Movie;
                }
            }

            return null;
        }

        // Show

        // GetShowByTitle
        // Accessor // Return Type // Name (Parameters)
        public Show GetShowByTitle(string title)
        {
            foreach (StreamingContent show in _contentDirectory)
            {
                if (show.Title.ToLower() == title.ToLower() && show.GetType() == typeof(Show))
                {
                    return (Show)show;
                }
            }

            return null;
        }

        // Episode

        public bool UpdateExistingContent(string originalTitle, StreamingContent newContentValues)
        {
            StreamingContent oldContent = GetContentByTitle(originalTitle);

            if (oldContent != null)
            {
                oldContent.Title = newContentValues.Title;
                oldContent.Description = newContentValues.Description;
                oldContent.StarRating = newContentValues.StarRating;
                oldContent.TypeOfGenre = newContentValues.TypeOfGenre;
                oldContent.MaturityRating = newContentValues.MaturityRating;

                return true;
            }
            else
            {
                return false;
            }
        }

        public bool DeleteExistingContent(string titleToDelete)
        {
            StreamingContent contentToDelete = GetContentByTitle(titleToDelete);
            if(contentToDelete != null)
            {
                _contentDirectory.Remove(contentToDelete);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
