using Microsoft.AspNetCore.Mvc;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ProductManagement.Models
{
    public class Product
    {
        [Key]
        public int? ProductId { get; set; }

        [Required, StringLength(200)]
        public string? ProductName { get; set; }

        [Required]
        [ForeignKey("Category")]
        public int? CategoryId { get; set; }

        public virtual Category? Category { get; set; }
    }
}
