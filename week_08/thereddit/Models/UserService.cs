using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace thereddit.Models
{
    public class UserService: IUser
    {
        public List<User> Users { get; set; } = new List<User>();
        public User CurrentUser { get; set; }

        public UserService()
        {
            Users = new List<User>();
        }
        public List<Post> AddPost(Post post)
            {
                CurrentUser.UsersPosts.Add(post);
                return CurrentUser.UsersPosts;
            }
            public User SetCurrentUser(string name)
            {
                CurrentUser = Users.First(user => name == user.Name);
                return CurrentUser;
            }
            public User GetCurrentUser()
            {
                return CurrentUser;
            }

            public List<Post> FindPostsByUser(string name)
            {
                CurrentUser = Users.First(user => name == user.Name);
                return CurrentUser.UsersPosts;
            }
        }
}
