using Newtonsoft.Json;

namespace Movies.Web.Data.Dto
{
    [JsonObject]
    public class MovieDto
    {
        [JsonProperty("id")]
        public int Id { get; set; }
        [JsonProperty("imdb_id")]
        public string? ImdbId { get; set; }
        [JsonProperty("title")]
        public string Title { get; set; } = string.Empty;
        [JsonProperty("original_title")]
        public string OriginalTitle { get; set; } = string.Empty;
        [JsonProperty("overview")]
        public string? Description { get; set; }
        [JsonProperty("releas_date")]
        public DateTime ReleasedDate { get; set; }
        [JsonProperty("popularity")]
        public int Popularity { get; set; }
        [JsonProperty("poster_path")]
        public string? PosterPath { get; set; }
        [JsonProperty("vote_average")]
        public int VoteAverage { get; set; }
        [JsonProperty("vote_count")]
        public int VoteCount { get; set; }
    }
}
