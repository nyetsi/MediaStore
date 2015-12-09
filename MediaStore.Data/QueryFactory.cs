using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MediaStore.Data.DataModels;

namespace MediaStore.Data
{
    public class QueryFactory
    {
        public static string GetAll(string type)
        {
            return string.Format("Select * from Media m inner join {0} b on b.Id = m.Id", type);
        }

        public static string FindById(string type)
        {
            return string.Format("Select * from Media m inner join {0} a on m.Id = a.Id where m.Id = @id", type);
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

        public static string CreateBook
        {
            get
            {
                return "Insert into Book(Id, Author, ISBN, Publisher)" +
                       "values (@Id, @Author, @ISBN, @Publisher)";
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

    }
}
