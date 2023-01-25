﻿using System.ComponentModel.DataAnnotations;

namespace SoftwareStore.Models
{
    public class Platform
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public string ImageURL { get; set; }
        public string Slug { get; set; }
    }
}
