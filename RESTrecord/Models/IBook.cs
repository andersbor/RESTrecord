using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTrecord.Models
{
    public interface IBook
    {
        public int Id { get; }
        public string Title { get; }
        public string Author { get; }
        public int Price { get; }
    }
}
