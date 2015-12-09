using System;
using System.Linq;
using System.Runtime.InteropServices;
using MediaStore.Core.Resources;
using MediaStore.Data;
using MediaStore.Data.DataModels;
using NSubstitute.Core;
using NSubstitute.ReturnsExtensions;
using NUnit.Framework;
using NSubstitute;

namespace MediaStore.Tests
{
    [TestFixture]
    public class BookTests
    {
        private IDataContext _context;
        private string _type;

        [SetUp]
        public void Setup()
        {
            _context = Substitute.For<IDataContext>();
            _type = "Book";
        }

        [Test]
        public void For_GetAllBooks_Given_TypeBook_Should_ReturnCollectionOfBooks()
        {
            string query = QueryFactory.GetAll(_type);
            var books = _context.GetAll<Book>(query);

            _context.Received().GetAll<Book>(query);
        }

        [Test]
        public void For_InsertBook_Given_Object_Should_ReturnInserted_RecordId()
        {
            var viewModel = MockData();
            int mediaId = _context.Create(QueryFactory.CreateMedia, viewModel);

            Assert.IsInstanceOf<int>(mediaId);
        }

        [Test]
        public void For_GetBookById_Given_BookId_ShouldReturn_BookObject()
        {
            string query = QueryFactory.FindById(_type);
            var result = _context.FindById<Book>(query, 1);

            _context.IsCompatibleWith(typeof (Book));
            _context.Received().FindById<Book>(query, 1);
        }

        private static Media MockData()
        {
            return new Media()
            {
                MediaTypeId = (int) MediaType.Cd,
                Title = "Me and my friends",
                ReleaseDate = new DateTime(2007, 10, 14),
                CoverArtId = 0,
                CreatedDate = DateTime.Now
            };
        }
    }
}
