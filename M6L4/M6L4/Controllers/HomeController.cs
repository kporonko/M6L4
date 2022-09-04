﻿using M6L4.Core.Models;
using M6L4.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

namespace M6L4.Controllers
{
    public class HomeController : Controller
    {
        private readonly ILogger<HomeController> _logger;
        private readonly IBookService _bookService;
        public HomeController(ILogger<HomeController> logger, IBookService bookService)
        {
            _logger = logger;
            _bookService = bookService;
        }

        [HttpGet]
        [Route("Home/Book/{id:int}")]
        public IActionResult Book([FromRoute] int id)
        {
            Book book = _bookService.GetBook(id);
            return View(book);
        }

        public IActionResult Index()
        {
            var books = _bookService.GetBooks();
            return View(books);
        }

        [HttpDelete]
        public IActionResult BookDelete(int id)
        {
            _bookService.DeleteBook(id);
            return RedirectToAction("Index");
        }

        [HttpGet]
        public IActionResult AddItem()
        {
            return View();
        }
        [HttpPost]
        public IActionResult AddItem(int Id ,string Title, DateTime ReleaseDate, string Image, string Description, string AuthorFullName, double Price, int BooksSold)
        {
            Book newBook = new Book { Id = Id, Title = Title, ReleaseDate = ReleaseDate, Image = Image, Description = Description, AuthorFullName = AuthorFullName, Price = Price, BooksSold = BooksSold };
            _bookService.AddBook(newBook);
            return Content("Successfully added");
        }


        public IActionResult Privacy()
        {
            return View();
        }

        [ResponseCache(Duration = 0, Location = ResponseCacheLocation.None, NoStore = true)]
        public IActionResult Error()
        {
            return View(new ErrorViewModel { RequestId = Activity.Current?.Id ?? HttpContext.TraceIdentifier });
        }
    }
}