﻿using System.ComponentModel.DataAnnotations;

namespace Blog_App_Dev.Models
{
    public class BlogPost
    {
        [Required]
        public int ID { get; set; }
        [Required]
        public string Title { get; set; }
        [Required]
        public string Content { get; set; }
        [Required]
        public DateTime DatePosted { get; set; } = DateTime.Now;
        public string? UserID { get; set; }
        public virtual ApplicationUser? User { get; set; }
        public ICollection<Comment>? Comments{ get; set; }
    }

}
