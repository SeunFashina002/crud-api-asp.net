using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Threading.Tasks;

namespace TodoApi.Models
{
    public class TodoItem
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please enter a task")]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsComplete { get; set; }

        // public DateTime CreatedAt { get; set; } = DateTime.Now;
    }
}
