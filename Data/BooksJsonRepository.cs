using Assignment1.Models;
//using Nancy.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Text.Json;
using System.Threading.Tasks;

namespace Assignment1.Data
{
    public class BooksJsonRepository :IBooksRepository
    {
         public BooksJsonRepository()
        {
            string url = "https://www.googleapis.com/books/v1/volumes?q=harry+potter";
            var client = new WebClient();
            var content = client.DownloadString(url);

            Console.WriteLine(content);
            BookCollection myCollection = JsonSerializer.Deserialize<BookCollection>(content);
            BookCollections = new List<BookCollection>() { myCollection };
            
        }
        public ICollection<BookCollection> BookCollections { get; set; }
       
        public ICollection<Book> GetBooks()
        {
            if (BookCollections.Count > 0)
            {
                return BookCollections.ToList()[0].Items;
            }
            else
            {
                return null;
            }
        }
    }
}
