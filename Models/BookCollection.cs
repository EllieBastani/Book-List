using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace Assignment1.Models
{
    public class BookCollection
    {
        //[Key]
        //public int Id { get; set; }
        [JsonPropertyName("kind")]
        public string Kind { get; set; }

        [JsonPropertyName("totalItems")]
        public int TotalItems { get; set; }

        [JsonPropertyName("items")]
        public ICollection<Book> Items { get; set; }
    }
}
