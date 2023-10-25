using System.ComponentModel.DataAnnotations;

namespace TodoApi.DTO
{
    public class TodoitemDTO
    {
        public int Id { get; set; }

        [Required(ErrorMessage = "please enter a task")]
        [StringLength(100)]
        public string Name { get; set; }

        public bool IsComplete { get; set; }
    }
}
