using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using MediaStore.Core.Interface;
using MediaStore.Core.Resources;
using MediaStore.Data;
using MediaStore.Data.DataModels;

namespace MediaStore.Core.Services
{
    public class BookService : IMedia<Book>
    {
        private DataContext _context;
        public DataContext Context
        {
            get { return _context ?? (_context = new DataContext()); }
            set { _context = value; }
        }

        public void AddMedia(Book media)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetMediaList(MediaType type)
        {
            return _context.GetAll<Book>(QueryFactory.GetAllBooks, (int) MediaType.Book);
        }

        public Book GetMediaById(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Book> GetAllMediaByType(MediaType type)
        {
            throw new NotImplementedException();
        }
    }
}
