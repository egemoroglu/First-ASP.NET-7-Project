using Microsoft.EntityFrameworkCore.Metadata.Internal;
using System.ComponentModel.DataAnnotations;

namespace FinalProject.Models
{
    public class Comment
    {
        [Key]
        public int id { get; set; }
        [Required]
        public string fullName { get; set; }
        [Required]
        public string email { get; set; }
        [Required]
        public string phoneNum { get; set; }
        [Required]
        public string message { get; set; }
    }
}
