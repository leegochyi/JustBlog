#region Usings
using JustBlog.Core;
using JustBlog.Core.Objects;
using JustBlog.Core.Mappings;
using System.Collections.Generic;
#endregion

namespace JustBlog.Models
{
    public class ListViewModel
    {
        public ListViewModel(IBlogRepository blogRepository, int p)
        {
            Posts = blogRepository.Posts(p - 1, 10);
            TotalPosts = blogRepository.TotalPosts();
        }

        public IList<Post> Posts { get; private set; }
        public int TotalPosts { get; private set; }


    }


}