﻿using MediatR;

namespace CoreWiki.Application.Articles.Queries
{
	public class GetArticlesToCreateFromArticle : IRequest<string[]>
	{
		public GetArticlesToCreateFromArticle() 
		{
		}

	}

}