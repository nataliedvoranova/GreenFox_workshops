using System.Collections.Generic;

namespace thereddit.Models
{
    public interface IUser
    {
        List<User> Users { get; set; }
        User CurrentUser { get; set; }
        List<Post> AddPost(Post post);
        User SetCurrentUser(string name);
        User GetCurrentUser();
        List<Post> FindPostsByUser(string name);

    }
}