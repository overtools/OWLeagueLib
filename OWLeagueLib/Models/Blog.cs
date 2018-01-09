using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class Blog {
        public string Author { get; set; }
        public long BlogId { get; set; }
        public string Content { get; set; }
        public string DefaultUrl { get; set; }
        public string Embed { get; set; }
        public List<string> Keywords { get; set; }
        public long Publish { get; set; }
        public string Summary { get; set; }
        public Image Thumbnail { get; set; }
        public Image Header { get; set; }
        public string Title { get; set; }
        public long Created { get; set; }
        public long Updated { get; set; }
        public string Locale { get; set; }
        public string CommentKey { get; set; }
        public string Status { get; set; }
        public string DefaultCommunity { get; set; }
        public bool CommentsEnabled { get; set; }
        public bool PollAttached { get; set; }
        public long LocalizationPublish { get; set; }
        public string SiteCategory { get; set; }
        public bool Draft { get; set; }
        public bool ShowPTR { get; set; }
        public bool FeaturedMap { get; set; }
        public bool ShowRating { get; set; }
        public bool Spotlight { get; set; }
        public bool CustomPublish { get; set; }
        public List<string> Tags { get; set; }
        public bool StickyForThisLocale { get; set; }
    }

    public class Image {
        public long MediaId { get; set; }
        public string Url { get; set; }
        public string MimeType { get; set; }
        public string Type { get; set; }
        public long Size { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public string OriginalFileName { get; set; }
        public long MediaType { get; set; }
    }
}