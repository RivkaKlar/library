using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Library.Core.Models
{
    public class Lend
    {
        public int Id { get; set; }
        public int UserId { get; set; }
            public int BookId { get; set; }
        public DateTime DateOfTakenTheBook { get; set; }
    }
}
