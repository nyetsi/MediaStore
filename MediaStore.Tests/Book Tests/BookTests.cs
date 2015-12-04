using System;
using System.Linq;
using MediaStore.Core.Resources;
using MediaStore.Data;
using MediaStore.Data.DataModels;
using NUnit.Framework;

namespace MediaStore.Tests
{
    [TestFixture]
    public class BookTests
    {
        private DataContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new DataContext();
        }

        [Test]
        public void For_Get_All_Books_Given_Type_Book_Should_Return_Collection_Of_Books()
        {
            var books = _context.GetAll<Book>(QueryFactory.GetAllBooks, (int) MediaType.Book);
            Assert.AreEqual(true, books.Any());
        }

        [Test]
        public void For_Insert_Book_Given_Object_Should_Return_Identity_Int()
        {
            var viewModel = new Media() { MediaTypeId = (int)MediaType.Cd, Title = "Me and my friends", ReleaseDate = new DateTime(2007, 10, 14), CoverArtId = 0, CreatedDate = DateTime.Now };
            int mediaId = _context.CreateMedia(QueryFactory.CreateMedia, viewModel);
            Assert.IsInstanceOf<int>(mediaId);

            var bookModel = new Book() { Id = mediaId, Author = "Matt Damon", ISBN = "1666-254-22", Publisher = "Matt Publishers" };
            _context.Create(QueryFactory.CreateBook, bookModel);
        }
    }
}
