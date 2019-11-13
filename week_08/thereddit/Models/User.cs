using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace thereddit.Models
{
    public class User
    {
        [DefaultValue("")]
        public string Name { get; set; } 
        [Key]
        public long Id { get; set; }
        public List<Post> UsersPosts { get; set; } = new List<Post>();

        public User(string name)
        {
            Name = name;
            UsersPosts = new List<Post>();
        }

    }
}
