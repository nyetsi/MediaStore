using System;
using System.Linq;
using MediaStore.Core.Resources;
using MediaStore.Data;
using MediaStore.Data.DataModels;
using NUnit.Framework;

namespace MediaStore.Tests.CdTests
{
    [TestFixture]
    public class CdTests
    {
        private DataContext _context;

        [SetUp]
        public void Setup()
        {
            _context = new DataContext();
        }

        [Test]
        public void For_Get_All_Cds_Given_Type_Cd_Should_Return_Collection_Of_Cds()
        {
            var books = _context.GetAll<Cd>(QueryFactory.GetAllCds, (int)MediaType.Cd);
            Assert.AreEqual(true, books.Any());
        }

        [Test]
        public void For_Insert_Cd_Given_Object_Should_Return_New_Record_Identity()
        {
            var viewModel = new Media() { MediaTypeId = (int)MediaType.Cd, Title = "Chapter One", ReleaseDate = new DateTime(2014, 07, 30), CoverArtId = 0, CreatedDate = DateTime.Now };
            int mediaId = _context.CreateMedia(QueryFactory.CreateMedia, viewModel);
            Assert.IsInstanceOf<int>(mediaId);

            var cdModel = new Cd() { Id = mediaId, Artist = "Ella Henderson", Album = "One", Genre = "Country" };
            _context.Create(QueryFactory.CreateCd, cdModel);
        }
    }
}
