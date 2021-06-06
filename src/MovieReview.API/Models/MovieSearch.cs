using System.Collections.Generic;

namespace MovieReview.API.Models
{
    public class MovieSearch : PaginationFilter
    {
        public string Title { get; set; }
        public string Director { get; set; }
        public string Genre { get; set; }
        public string Actor { get; set; }

        public Dictionary<string, object> Filters()
        {
            var filters = new Dictionary<string, object>();

            if (Title != null)
                filters.Add("Title", Title);

            if (Director != null)
                filters.Add("Director", Director);

            if (Actor != null)
                filters.Add("Actor", Actor);

            if (Genre != null)
                filters.Add("Genre", Genre);

            return filters;
        }
    }
}
