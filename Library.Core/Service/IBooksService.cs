using Books.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Books.Core.Service
{
    public interface IBooksService
    {
        public List<Book> GetAll();
    }
}
