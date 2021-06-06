using MovieReview.API.Models;
using System;

namespace MovieReview.API.Interfaces
{
    public interface IUriService
    {
        public Uri GetPageUri(PaginationFilter filter, string route);
    }
}
