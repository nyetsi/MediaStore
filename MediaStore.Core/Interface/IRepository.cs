using System;
using System.Collections.Generic;
using System.Dynamic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MediaStore.Core.Interface
{
    interface IRepository<T>
    {
        void InsertIntoDb(T item);
        T GetItemById(int id);
    }
}
