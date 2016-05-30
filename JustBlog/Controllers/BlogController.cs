#region Usings
using System;
using System.Configuration;
using System.Linq;
using System.Text;
using System.Web;
using JustBlog;
using JustBlog.Core;
using JustBlog.Core.Objects;
using JustBlog.Models;
using System.Web.Mvc;
#endregion

namespace JustBlog.Controllers
{
    public class BlogController : Controller
    {
        private readonly IBlogRepository _blogRepository;

        public BlogController(IBlogRepository blogRepository)
        {
            _blogRepository = blogRepository;
        }

        public ViewResult Posts(int p = 1)
        {
            //pick latest 10 posts
            //var posts = _blogRepository.Posts(p - 1, 10);

            //var totalPosts = _blogRepository.TotalPosts();

            //var listViewNodel = new ListViewModel
            //{
            //    Posts = posts,
            //    TotalPosts = totalPosts
            //};
            var viewModel = new ListViewModel(_blogRepository, p);
            ViewBag.Title = "Lastest Posts";
            return View("List", viewModel);

        }

        public ViewResult Category(string category, int p =1 )
        {
            // TODO: get the posts for the category and return the view
            var viewModel = new ListViewModel(_blogRepository, category, "Category", p);

            if (viewModel.Category == null)
                throw new HttpException(404, "Category not found 無法找到指定Category");

            ViewBag.Title = String.Format(@"Latest posts on category ""{0}""",
                viewModel.Category.Name);

            return View("List", viewModel);
        }

        public ViewResult Tag(string tag, int p = 1)
        {
            // TODO: get the posts for the tag and return the view
            var viewModel = new ListViewModel(_blogRepository, tag, "Tag", p);

            if (viewModel.Tag == null)
                throw new HttpException(404, "Tag not found 無法找到指定Tag");

            ViewBag.Title = String.Format(@"Latest posts tagged on  ""{0}""", viewModel.Tag.Name);

            return View("List", viewModel);
        }

    }
}