using System.ComponentModel.DataAnnotations;

namespace Models.TodoItem{

    public class TodoItem{
        [Key]
        [Required]
        public int TodoId { get; set; }

        [Required]        
        public string TodoTitle { get; set; }

        public string TodoDescription {get; set;}

        public bool TodoIsCompleted { get; set; }
    }
}