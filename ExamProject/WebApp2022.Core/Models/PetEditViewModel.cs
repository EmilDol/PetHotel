﻿using System.ComponentModel.DataAnnotations;

using WebApp2022.Infrastructure.Data.Enums;

namespace WebApp2022.Core.Models
{
    public class PetEditViewModel
    {
        public Guid Id { get; set; }

        [Required]
        [MinLength(3)]
        [MaxLength(20)]
        public string Name { get; set; } = null!;

        [Required]
        [MinLength(20)]
        [MaxLength(300)]
        public string Description { get; set; } = null!;

        [Required]
        [MaxLength(200)]
        public string Requirements { get; set; } = null!;

        [Required]
        public string ImageUrl { get; set; } = null!;

        [Required]
        [DataType(DataType.Date)]
        public DateTime DateAdded { get; set; }

        [Required]
        public double Heigth { get; set; }

        [Required]
        public double Weigth { get; set; }

        [Required]
        public int Age { get; set; }

        [Required]
        public string Type { get; set; } = null!;
    }
}