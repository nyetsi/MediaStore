using System.Linq;
using MediaStore.Data;
using MediaStore.Data.DataModels;
using NUnit.Framework;

namespace MediaStore.Tests
{
    [TestFixture]
    public class BookTests
    {
        [Test]
        public void For_Get_All_Books_Given_Type_Book_Should_Return_Collection_Of_Books()
        {
            var context = new DataContext();
            const int type = 1;
            var books = context.GetAll<Book>(type);

            Assert.AreEqual(true, books.Any());
        }
    }
}
