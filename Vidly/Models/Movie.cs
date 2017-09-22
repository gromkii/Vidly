﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

using System.Linq;
using System.Web;

namespace Vidly.Models
{
    public class Movie
    {
        public int Id { get; set; }

        [Required]
        [StringLength(255)]
        public string Name { get; set; }

        
        public Genre Genre { get; set; }

        [Required]
        public byte GenreId { get; set; }

        [Display(Name = "Number in Stock")]
        [Range(1,20)]
        public byte NumberInStock { get; set; }

        [Required]
        public DateTime? ReleaseDate { get; set; }

        public DateTime? CreatedAt { get; set; }

        public Movie()
        {
            this.CreatedAt = DateTime.Now;
        }

    }
}