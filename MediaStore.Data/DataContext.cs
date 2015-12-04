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
        private readonly IDbConnection _db =
            new SqlConnection("Data Source=KYOTO\\KYOTO;Initial Catalog=MediaStore;Integrated Security=True");

        public List<T> GetAll<T>(string query, int type)
        {
            return _db.Query<T>(query + @type).ToList();
        }

        public int CreateMedia(string query, Media viewModel)
        {
            int id = _db.Query<int>(query, viewModel).Single();
            return id;
        }

        public void Create<T>(string query, T viewModel)
        {
            _db.Query<int>(query, viewModel);
        }
    }
}
