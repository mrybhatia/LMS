using System.Collections.Generic;
using LMS.Models;
using Microsoft.AspNetCore.Mvc;

namespace LMS.Controllers
{
    [Route("api/book")]
    [ApiController]
    public class BookController : ControllerBase
    {
        [Route("{bookId}")]
        public Book GetBook(int bookId)
        {
            return new Book();
        }

        [Route("multiple")]
        public IEnumerable<Book> GetBooks(List<int> bookIds)
        {
            return new List<Book>();
        }

        [Route("all")]
        public IEnumerable<Book> GetAllBooks()
        {
            return new List<Book>();
        }

        [Route("add")]
        public bool PostBook(Book book)
        {
            return true;
        }

        [Route("delete")]
        public bool DeleteBook(int bookId)
        {
            return true;
        }

        [Route("update")]
        public bool PutUpdateBook(Book book)
        {
            return true;
        }

        [Route("{bookId}/member/{memberId}/issue")]
        public bool PostIssueBook(int bookId, int memberId)
        {
            return true;
        }

        [Route("{bookId}/member/{memberId}/return")]
        public bool PutReturnBook(int bookId, int memberId)
        {
            return true;
        }
    }
}
