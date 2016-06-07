using JustBlog.Core.Objects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace JustBlog.Core
{
    /// <summary>
    /// Defines all the database methods required for JustBlog
    /// 定義所有的資料庫方法 回傳到JustBlog
    /// </summary>
    public interface IBlogRepository
    {
        /// <summary>
        /// Return collection of posts based of pagination parameters
        /// 回傳 posts 的分頁參數集合
        /// </summary>
        /// <param name="pageNo">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <returns></returns>
        IList<Post> Posts(int pageNo, int pageSize);

        /// <summary>
        /// Return collenction of posts belongs to a partucular category.
        /// </summary>
        /// <param name="categorySlug">Category's url slug</param>
        /// <param name="pageNo">Page index</param>
        /// <param name="pageSize">Page size</param>
        /// <returns></returns>
        IList<Post> PostsForCategory(string categorySlug, int pageNo, int pageSize);

        /// <summary>
        /// Return collenction of posts belongs to a particular tag.
        /// </summary>
        /// <param name="tagSlug"></param>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IList<Post> PostsForTag(string tagSlug, int pageNo, int pageSize);

        /// <summary>
        /// Fetch the posts that matches the search text
        /// </summary>
        /// <param name="search"></param>
        /// <param name="pageNo"></param>
        /// <param name="pageSize"></param>
        /// <returns></returns>
        IList<Post> PostsForSearch(string search, int pageNo, int pageSize);

        IList<Category> Categories();
        /// <summary>
        /// Return total no. of posts belongs to a particular category.
        /// 回傳posts 所屬指定category總和頁數
        /// </summary>
        /// <param name="categorySlug"></param>
        /// <returns></returns>
        int TotalPostsForCategory(string categorySlug);

        /// <summary>
        ///Return total no. of posts belongs to a particular category.
        /// 回傳posts 所屬指定tag總和頁數
        /// </summary>
        /// <param name="tagSlug"></param>
        /// <returns></returns>
        int TotalPostsForTag(string tagSlug);

        /// <summary>
        /// Display the total number of posts matches the search text for pagination
        /// </summary>
        /// <param name="search"></param>
        /// <returns></returns>
        int TotalPostsForSearch(string search);

        /// <summary>
        /// 
        /// </summary>
        /// <param name="year"></param>
        /// <param name="month"></param>
        /// <param name="titleSlug"></param>
        /// <returns></returns>
        Post Post(int year, int month, string titleSlug);

        /// <summary>
        /// Retrun category based on url slug
        /// 回傳基礎category到網址區塊
        /// </summary>
        /// <param name="categorySlug"></param>
        /// <returns></returns>
        Category Category(string categorySlug);

        /// <summary>
        /// Return tag based on url slug.
        /// 回傳基礎tag分類到網址區塊
        /// </summary>
        /// <param name="tagSlug"></param>
        /// <returns></returns>
        Tag Tag(string tagSlug);

        /// <summary>
        /// Return total no. of tags
        /// 回傳 tags 總數
        /// </summary>
        /// <returns></returns>
        int TotalPosts();
    }
}
