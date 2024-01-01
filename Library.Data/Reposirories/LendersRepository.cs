using Books.Data;
using Library.Core.Models;
using Library.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Data.Reposirories
{
    public class LendersRepository: ILendersRepository
    {
        private readonly DataContext _DataContext;

        public LendersRepository(DataContext DataContext)
        {
            _DataContext = DataContext;
        }
        public List<Lend> GetList()
        {
            return _DataContext.Lenders.ToList();

        }
    }
}
