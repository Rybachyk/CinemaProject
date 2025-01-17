﻿namespace Cinema.Models.DataBaseModels
{
    public class Movies
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public int DurationMinutes { get; set; }
        public string Genre { get; set; }
        public string TrailerUrl { get; set; }
        public string PosterUrl { get; set; }
        public decimal Rating { get; set; }
    }
}
