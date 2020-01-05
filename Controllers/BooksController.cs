using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using Assignment1.Data;
using Assignment1.Models;
using Microsoft.AspNetCore.Authorization;

namespace Assignment1.Controllers
{
    [Authorize]
    public class BooksController : Controller
    {
        private readonly IBooksRepository _context;

        public BooksController(IBooksRepository context)
        {
            _context = context;
        }

        // GET: BookCollections
        public IActionResult Index()
        {

            return View(_context.GetBooks());
        }

        // GET: BookCollections/Details/5
        #nullable enable
        public IActionResult Details(string? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var book = _context.GetBooks().First<Book>
                (m => m.Id == id);
            if (book == null)
            {
                return NotFound();
            }

            return View(book);
        }



        /*private bool BookCollectionExists(int id)
        {
            return _context.Books.Any(e => e.Id == id);
        }*/
    }
}
