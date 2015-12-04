using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore.Data
{
    public class QueryFactory
    {
        public static string GetAllBooks
        {
            get { return "Select * from Media m inner join Book b on b.Id = m.Id and m.MediaTypeId = "; }
        }

        public static string GetAllCds
        {
            get { return "Select * from Media m inner join Cd b on b.Id = m.Id and m.MediaTypeId = "; }
        }

        public static string CreateMedia
        {
            get
            {
                return "Insert into Media(MediaTypeId, Title, ReleaseDate, CoverArtId, CreatedDate)" +
                       "values (@MediaTypeId, @Title, @ReleaseDate, @CoverArtId, @CreatedDate);" +
                       "SELECT CAST(SCOPE_IDENTITY() as int)";
            }
        }

        public static string CreateCd
        {
            get
            {
                return "Insert into Cd(Id, Artist, Album, Genre)" +
                       "values (@Id, @Artist, @Album, @Genre)";
            }
        }

        public static string CreateBook
        {
            get
            {
                return "Insert into Book(Id, Author, ISBN, Publisher)" +
                       "values (@Id, @Author, @ISBN, @Publisher)";

            }
        }
    }
}
