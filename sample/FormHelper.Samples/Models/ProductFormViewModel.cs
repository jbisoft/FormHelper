﻿using FormHelper.Samples.Enums;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;

namespace FormHelper.Samples.Models
{
    public class ProductFormViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public Category Category { get; set; }
        [Display(Name = "In Stock")]
        public int InStock { get; set; }
        public bool Active { get; set; } = true;
        public IFormFile File { get; set; }
        public UserType UserType { get; set; } = UserType.User;

        public bool IsNew => Id == default;
    }
}
