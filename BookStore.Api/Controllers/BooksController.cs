using BookStore.Application;
using BookStore.Contracts;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.Controllers;

[ApiController]
[Route("controller")]
public class BooksController : ControllerBase
{
    private readonly IBookService _bookServices;

    public BooksController(IBookService bookService)
    {
        _bookServices = bookService;
    }

    [HttpGet]
    public async Task<ActionResult<List<BooksRespons>>> GetBooks()
    {
        var books = await _bookServices.GetAllBook();

        var response = books.Select(b => new BooksRespons(b.Id, b.Title, b.Description, b.Price));

        return Ok(response);
    }
    
    
}