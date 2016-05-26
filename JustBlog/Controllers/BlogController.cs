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

    }
}