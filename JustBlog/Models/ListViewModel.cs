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
        public ListViewModel
            (IBlogRepository blogRepository, int p)
        {
            Posts = blogRepository.Posts(p - 1, 10);
            TotalPosts = blogRepository.TotalPosts();
        }

        public ListViewModel
            (IBlogRepository blogRepository, string categorySlug, int p )
        {
            Posts = blogRepository.PostsForCategory(categorySlug, p - 1, 10);

            TotalPosts = blogRepository.TotalPostsForCategory(categorySlug);

            Category = blogRepository.Category(categorySlug);

        }

        public ListViewModel
            (IBlogRepository blogRepository, string text, string type, int p)
        {
            switch (type)
            {
                case "Tag":
                    Posts = blogRepository.PostsForTag(text, p - 1, 10);
                    TotalPosts = blogRepository.TotalPostsForTag(text);
                    Tag = blogRepository.Tag(text);
                    break;
                default:
                    Posts = blogRepository.PostsForTag(text, p - 1, 10);
                    TotalPosts = blogRepository.TotalPostsForCategory(text);
                    Category = blogRepository.Category(text);
                    break;
            }
        }
     


        public IList<Post> Posts { get; private set; }


        public int TotalPosts { get; private set; }


        public Category Category { get; private set; }


        public Tag Tag { get; private set; }
    }


}