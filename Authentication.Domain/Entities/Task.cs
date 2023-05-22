using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Authentication.Domain.Entities
{
    [Table("Task")]
    public class Task
    {
        [Column("TaskId")]
        public int Id { get; set; }

        [Required(ErrorMessage = "CreatedAt is required")]
        public DateTime CreatedAt { get; set; }

        [Required(ErrorMessage = "Progress is required")]
        public string? Progress { get; set; }
        [ForeignKey(nameof(Todo))]
        public int TodoId { get; set; }
        [JsonIgnore]
        public Todo? Todo { get; set; }
    }
}
