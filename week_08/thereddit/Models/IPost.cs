using System.Collections.Generic;

namespace thereddit.Models
{
    public interface IPost
    {
        List<Post> Posts { get; set; }
        List<Post> AddPost(Post post);
    }
}