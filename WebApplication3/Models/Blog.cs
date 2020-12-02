using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace WebApplication3.Models
{
    public class Blog
    {
      
        public Blog(string userId)
        {
            this.UserId = userId;
        }

        [Key]
        public int IdBlog { get; set; }
        public string UserId { get; set; }
    }
}
