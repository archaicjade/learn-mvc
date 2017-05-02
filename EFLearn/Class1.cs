using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EFLearn
{
    public class BlogUser
    {
        public int BlogUserId { get; set; }

        public string BlogName { get; set; }

        public virtual ICollection<Post> Posts { get; set; }
    }

    public partial class Post
    {
        public int PostId { get; set; }

        public string PostTitle { get; set; }

        public int BlogUserId { get; set; }

        public virtual BlogUser BlogUser { get; set; }
    }
}
