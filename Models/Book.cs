using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class Book
    {
        [Key]

        [JsonPropertyName("id")]  public string Id { get; set; }

        [JsonPropertyName("volumeInfo")] public Volume VolumeInfo { get; set; }

        
/*
        public int BookCollectionId { get; set; }
        public BookCollection BookCollection { get; set; }
        */
    }
}
