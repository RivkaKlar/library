
using Library.Core.Models;
using Library.Core.Repositories;
using Library.Core.Service;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Service
{
    public class UsersService: IUsersService
    {
        public readonly IUsersRepository _UsersService;

        public UsersService(IUsersRepository UsersService) 
        {
            _UsersService=UsersService;
        }
       
        public List<User> GetAll()
        {
            return _UsersService.GetList();
        }
   
    }
}
