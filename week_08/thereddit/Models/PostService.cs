using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thereddit.Models
{
    public class PostService: IPost
    {
        public List<Post> Posts { get; set; }

        public PostService()
        {

        }

        public List<Post> AddPost(Post post)
        {
            Posts.Add(post);
            return Posts;
        }
    }
}
