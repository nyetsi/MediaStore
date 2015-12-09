using System.Collections.Generic;
using MediaStore.Data.DataModels;

namespace MediaStore.Data
{
    public interface IDataContext
    {
        IEnumerable<T> GetAll<T>(string query);
        int Create<T>(string query, T viewModel);
        T FindById<T>(string query, int id);
    }
}