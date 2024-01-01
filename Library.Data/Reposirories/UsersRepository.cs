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
    public class UsersRepository: IUsersRepository
    {
        private readonly DataContext _context;
        public UsersRepository(DataContext context) 
        {
            _context = context;
        }
        public List<User> GetList()
        {
            return _context.Users.ToList();
        }
    }
}
