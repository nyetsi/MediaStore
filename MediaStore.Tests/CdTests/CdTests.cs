using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaStore.Data;
using MediaStore.Data.DataModels;
using NUnit.Framework;

namespace MediaStore.Tests.CdTests
{
    [TestFixture]
    public class CdTests
    {
        [Test]
        public void For_Get_All_Cds_Given_Type_Cd_Should_Return_Collection_Of_Cds()
        {
            var context = new DataContext();

            const int type = 2;

            var books = context.GetAll<Cd>(type);

            Assert.AreEqual(true, books.Any());
        }
    }
}
