using System;
using System.Collections.Generic;

namespace LambdaForums.Data.Models
{
    public class Post
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public DateTime Created { get; set; }

        public ApplicationUser User { get; set; }
        public virtual Forum Forum { get; set; }

        public virtual IEnumerable<Postreply> Replies { get; set; }
    }
}