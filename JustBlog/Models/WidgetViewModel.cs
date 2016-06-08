﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using JustBlog.Core;
using JustBlog.Core.Objects;

namespace JustBlog.Models
{
    public class WidgetViewModel
    {
        public WidgetViewModel(IBlogRepository blogRepository)
        {
            Categories = blogRepository.Categories();

            Tags = blogRepository.Tags();
        }

        public IList<Category> Categories { get; private set; }

        public IList<Tag> Tags { get; private set; }
    }
}