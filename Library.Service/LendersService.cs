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
    public class LendersService: ILenderService
    {
        private readonly ILendersRepository _LendersRepository;

        public LendersService(ILendersRepository LendersRepository)
        {
        _LendersRepository= LendersRepository;
        }

        public List<Lend> GetAll()
        {
            return _LendersRepository.GetList();
        }

    }
}
