using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BlazorWebCRUD.Shared.Models
{
    public class Book
    {
        [Key]
        public int Id { get; set; }
        [Required]
        [MinLength(3), MaxLength(100)]
        public string Title { get; set; }
        [Required]
        [MinLength(3), MaxLength(150)]
        public string Author { get; set; }
        public int PublishedYear { get; set; }
        [MinLength(0), MaxLength(300)]
        public string? Description { get; set; }
    }
}
