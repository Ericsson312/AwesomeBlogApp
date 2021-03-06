﻿using AwesomeBlogDTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace AwesomeBlogFrontEnd.Services
{
    public interface IApiClient
    {
        Task<BloggerResponse> GetBloggerAsync(int id);
        Task<BloggerResponse> GetBloggerByNameAsync(string name);
        Task<bool> AddBloggerAsync(Blogger blogger);

        Task<List<Article>> GetArticlesAsync();
        Task<List<Article>> GetArticlesByTagIdAsync(int id);
        Task<ArticleResponse> GetArticleAsync(int id);
        Task<Article> AddArticleAsync(Article article);
        Task PutArticleAsync(Article article);
        Task DeleteArticle(int id);

        Task<List<Tag>> GetTagsAsync();
        Task<List<Tag>> GetTagsPopularAsync();
        Task<bool> AddTag(int articleId, int tagId);
        Task RemoveTag(int articleId, int tagId);
        Task RemoveAllTags(int articleId);

        Task<bool> AddComment(int articleId, Comment comment);
        Task RemoveComment(int articleId, int commentId);
    }
}
