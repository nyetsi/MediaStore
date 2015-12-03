using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Dapper;
using MediaStore.Data.DataModels;

namespace MediaStore.Data
{
    public class DataContext
    {
        private readonly IDbConnection _db = new SqlConnection("Data Source=KYOTO\\KYOTO;Initial Catalog=MediaStore;Integrated Security=True");

        public List<T> GetAll<T>(int type) where T : new()
        {
            return
                _db.Query<T>(
                    "Select Title, ISBN, Author,Publisher,ReleaseDate from Media m inner join Book b on b.Id = m.Id and m.MediaTypeId = " + @type).ToList();
        }

        //public User Find(int id)
        //{
        //    return this._db.Query<User>("SELECT * FROM Users WHERE UserID = @UserID", new { id }).SingleOrDefault();
        //}
    }
}
