﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Meverex.Models;

namespace Meverex.ViewModels
{
    public class PostViewModel
    {
        public List<Post> Posts { get; set; }
        public List<News>  News { get; set; }
    }
}