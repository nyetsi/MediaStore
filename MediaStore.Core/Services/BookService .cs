using System.Collections.Generic;
using MediaStore.Core.Resources;
using MediaStore.Data;
using MediaStore.Data.DataModels;

namespace MediaStore.Core.Services
{
    public class BookService : DataContext
    {
        private readonly MediaType _type = MediaType.Book;

        public BookService(MediaType type)
        {
            _type = type;
        }

        public IEnumerable<Book> GetAllBooks()
        {
            return GetAll<Book>(QueryFactory.GetAll(_type.ToString()));
        }

        public int Create(Book book)
        {
            return Create(QueryFactory.CreateBook, book);
        }

        public Book GetBookById(int id)
        {
            return FindById<Book>(QueryFactory.FindById(_type.ToString()), id);
        }
    }
}
