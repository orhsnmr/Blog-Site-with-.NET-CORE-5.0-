using Microsoft.AspNetCore.Mvc;
using NetCore.Models;
using System.Collections.Generic;
using System.Net;

namespace NetCore.ViewComponents.Comment
{
    public class CommentList : ViewComponent
    {
        public IViewComponentResult Invoke()
        {
            var commentValues = new List<UserComment>
            {
                new UserComment
                {
                    ID = 1,
                    UserName = "Orhan"
                },
                new UserComment
                {
                    ID = 2,
                    UserName = "Hasan"
                }
            };

            return View(commentValues);

        }
    }
}

