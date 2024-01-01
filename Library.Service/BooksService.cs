using Books.Core.Models;
using Books.Core.Repositories;
using Books.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Service
{
    public class BooksService: IBooksService
    {
        private readonly IBooksRepository _booksRepository;

        public BooksService(IBooksRepository booksRepository)
        {
            _booksRepository = booksRepository;
        }


        public List<Book> GetAll()
        {
           return _booksRepository.GetList();
        }
    }
}
