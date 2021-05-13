using GameForum.Model;
using Microsoft.AspNetCore.Mvc.Rendering;
using System.Collections.Generic;

namespace GameForum.ViewModel
{
    public class CreatePostViewModel
    {
        public Post Post { get; set; }
        public List<SelectListItem> Categories { get; set; }
    }
}
