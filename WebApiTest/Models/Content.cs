﻿using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Diagnostics.CodeAnalysis;

namespace WebApiTest.Models
{
    public class Content
    {
        public int ContentId { get; set; }
        public string Title { get; set; }
        public string Body { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public string Author { get; set; }
        public VisibilityStatus Visibility { get; set; }

        [ForeignKey(nameof(Category.CategoryId))]
        public int CategoryId { get; set; }

        // navigation property
        public virtual Category? Category { get; set; }
    }
}
