﻿using Movie_List.Models;
using System.ComponentModel.DataAnnotations;

namespace Movie_List.Dtos
{
    public class MovieDto
    {
        public string Title { get; set; }

        public int year { get; set; }
        [Range(1,10)]
        public double Rate { get; set; }
        [Required, StringLength(250)]
        public string StoreLine { get; set; }

        public byte[] poster { get; set; }
        [Display (Name ="Genre")]
        public int GenreId { get; set; }
        public IEnumerable<Genre>Genres { get; set; }
    }
}
