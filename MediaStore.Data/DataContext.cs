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
    public class DataContext : IDataContext
    {
        //TODO: Move this to config
        private readonly IDbConnection _db =
            new SqlConnection("Data Source=KYOTO\\KYOTO;Initial Catalog=MediaStore;Integrated Security=True");

        public IEnumerable<T> GetAll<T>(string query)
        {
            return _db.Query<T>(query).ToList();
        }
        
        public int Create<T>(string query, T viewModel)
        {
            return _db.Query<int>(query, viewModel).Single();
        }

        public T FindById<T>(string query, int id)
        {
            return _db.Query<T>(query, new {id}).Single();
        }
    }
}
