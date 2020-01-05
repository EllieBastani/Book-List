using System;
using System.Collections.Generic;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment1.Models
{

    public class ThumbnailLinks
    {
        [JsonPropertyName("smallThumbnail")] public string SmallThumbnail { get; set; }
        [JsonPropertyName("thumbnail")] public string Thumbnail { get; set; }
    }

    public class IndustryIdentifiers
    {
        [JsonPropertyName("type")] public string Type { get; set; }
        [JsonPropertyName("identifier")] public string Identifier { get; set; }
    }

    public class Volume
    {
        [JsonPropertyName("title")] public string Title { get; set; }
        
        [JsonPropertyName("publisher")] public string Publisher { get; set; }

        [JsonPropertyName("publishedDate")] public string PublishDate { get; set; }

        [JsonPropertyName("description")] public string Description { get; set; }

        [JsonPropertyName("imageLinks")] public ThumbnailLinks ThumbnailURL { get; set; }

        [JsonPropertyName("authors")] public List<string> Authors { get; set; }
        [JsonPropertyName("industryIdentifiers")] public List<IndustryIdentifiers> IndustryIds { get; set; }


    }
}
