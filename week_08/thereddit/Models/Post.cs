using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thereddit.Models
{
    public class Post
    {
        [DefaultValue("")]
        public string Title { get; set; } 
        [DefaultValue(0)]
        public int Votes { get; set; }
        [Key]
        public long Id { get; set; }

        public Post(string title)
        {
            
        }
    }
}
