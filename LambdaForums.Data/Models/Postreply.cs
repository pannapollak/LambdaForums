using System;
namespace LambdaForums.Data.Models
{
    public class Postreply
    {
        public int Id { get; set; }
        public string Content { get; set; }
        public DateTime Created { get; set; }

        public ApplicationUser User { get; set; }
        public virtual Post Post { get; set; }
    }
}