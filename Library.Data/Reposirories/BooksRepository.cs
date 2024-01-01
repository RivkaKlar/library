using Books.Core.Models;
using Books.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Data.Reposirories
{
    public class BooksRepository: IBooksRepository
    {
        private readonly DataContext _context;
        public BooksRepository(DataContext context) 
        {
        _context= context;
        }

        public List<Book> GetList()
        {
            return _context.Books.ToList();
        }

    }
}
