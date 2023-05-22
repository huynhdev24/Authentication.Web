using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Authentication.Domain.Entities
{
    [Table("Todo")]
    public class Todo
    {
        [Column("TodoId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "Name is required")]
        [StringLength(60, ErrorMessage = "Name can't be longer than 60 characters")]
        public string? Name { get; set; }

        [Required(ErrorMessage = "CreatedAt is required")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Note is required")]
        [StringLength(100, ErrorMessage = "Note cannot be longer than 100 characters")]

        public string? Note { get; set; }

        public List<Task>? Tasks { get; set; } = new List<Task>();
    }
}
