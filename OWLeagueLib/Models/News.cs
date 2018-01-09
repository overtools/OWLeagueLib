using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class News {
        public List<Blog> Blogs { get; set; }
        public int Page { get; set; }
        public int PageSize { get; set; }
        public int TotalBlogs { get; set; }
        public int TotalPages { get; set; }
    }
}