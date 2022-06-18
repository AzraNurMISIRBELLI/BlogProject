using BlogProject.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BlogProject.ViewComponents
{
	public class CommentList:ViewComponent
	{
		public IViewComponentResult Invoke()
		{
			var commentvalues = new List<UserComment>
			{
					new UserComment
					{
						Id=1,
						UserName="Azra"
					},
					new UserComment
					{
						Id=2,
						UserName="Ahmet"
					},
					new UserComment
					{
						Id=3,
						UserName="Beyza"
					}
			};
			return View(commentvalues);
		}
	}
}
