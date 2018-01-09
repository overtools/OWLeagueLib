using System.Collections.Generic;

namespace OWLeagueLib.Models {
    public class PlaylistVideosResponse {
        public VideosMetadata Metadata { get; set; }
        public int Code { get; set; }
        public PlaylistData Data { get; set; }
        public string Status { get; set; }

        public class PlaylistData {
            public List<Vod> Videos { get; set; }
            public long ID { get; set; }
            public long UserID { get; set; }
            public string OrganizationID { get; set; }
            public string Name { get; set; }
            public string DisplayName { get; set; }
            public string PlayAs { get; set; }
            public string DisplayAs { get; set; }
            public bool Available { get; set; }
            public string CreatedAt { get; set; }
            public string UpdatedAt { get; set; }
        }

        public class VideosMetadata {
            public int Page { get; set; }
            public int PageCount { get; set; }
            public int TotalCount { get; set; }
        }
    }

    public class Vod {
        public string AvailableAt { get; set; }
        public string Description { get; set; }
        public string Embed { get; set; }
        public string Thumbnail { get; set; }
        public string Title { get; set; }
        public string UniqueID { get; set; }
        public long UserID { get; set; }
        public string OrganizationID { get; set; }
        public string VideoType { get; set; }
        public string Status { get; set; }

        public long Length { get; set; }

        // public object privacy; // todo unk type, probably string
        public bool Available { get; set; }
        public string VideoThumbnailID { get; set; }

        public string Location { get; set; }
        // more todo types
        //  public string eve_slug;
        //  public string stream_name;
        //  public string channel_slug;
        // (for more check api with pretty print)

        public string PublishType { get; set; }
        public string StatsAt { get; set; }
        public string RecordedAt { get; set; }
        public string BroadcastedAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
        public string ShareUrl { get; set; }
        public List<VodTag> Tags { get; set; }
        public List<VobThumbnail> Thumbnails { get; set; }
        public List<VideoAsset> VideoAssets { get; set; }
    }

    public class VodTag {
        public long ID { get; set; }
        public long TagTypeID { get; set; }
        public string TagType { get; set; }
        public string TagValue { get; set; }
        public string CreatedAt { get; set; }
    }

    public class VobThumbnail {
        public long ID { get; set; }
        public long VideoID { get; set; }
        public long SourceThumbnailID { get; set; }
        public string ThumbnailType { get; set; }
        public string ThumbnailUrl { get; set; }
        public string Size { get; set; }
        public long Width { get; set; }
        public long Height { get; set; }
        public string TimeAt { get; set; }
        public string CreatedAt { get; set; }
        public string UpdatedAt { get; set; }
    }

    public class VideoAsset {
        public string Format { get; set; }
        public string Source { get; set; }
        public string SourceUrl { get; set; }
    }
}