using MovieReview.API.Interfaces;
using MovieReview.API.Models;
using System;
using System.Collections.Generic;

namespace MovieReview.API.Helpers
{
    public class PaginationHelper
    {
        public static PagedResponse<List<T>> CreatePagedResponse<T>(List<T> pagedData, PaginationFilter validFilter, int totalRecords, IUriService uriService, string route)
        {
            var response = new PagedResponse<List<T>>(pagedData, validFilter.PageIndex, validFilter.PageSize);
            var totalPages = ((double)totalRecords / (double)validFilter.PageSize);
            int roundedTotalPages = Convert.ToInt32(Math.Ceiling(totalPages));

            response.NextPage = validFilter.PageIndex >= 1 && validFilter.PageIndex < roundedTotalPages
                     ? uriService.GetPageUri(new PaginationFilter(validFilter.PageIndex + 1, validFilter.PageSize), route) : null;

            response.PreviousPage = validFilter.PageIndex - 1 >= 1 && validFilter.PageIndex <= roundedTotalPages
                     ? uriService.GetPageUri(new PaginationFilter(validFilter.PageIndex - 1, validFilter.PageSize), route) : null;


            response.FirstPage = uriService.GetPageUri(new PaginationFilter(1, validFilter.PageSize), route);
            response.LastPage = uriService.GetPageUri(new PaginationFilter(roundedTotalPages, validFilter.PageSize), route);
            response.TotalPages = roundedTotalPages;
            response.TotalRecords = totalRecords;

            return response;
        }
    }
}
