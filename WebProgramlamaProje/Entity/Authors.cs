﻿using System.ComponentModel.DataAnnotations;

namespace WebProgramlamaProje.Entity
{
    public class Authors
    {
        [Key]
        public int AuthorID { get; set; } 
        public string AuthorName { get; set; }
        public string AuthorPassword { get; set; }
        public ICollection<Blogs> Blogs { get; set; }
    }
}
