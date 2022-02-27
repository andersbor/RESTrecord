using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace RESTrecord.Models
{
    public record BookRecord(int Id, string Title, string Author, int Price) : IBook;
    /*{
        public int Id { get; set; }
        public string Title { get; set; }
        public string Author { get; set; }
        public int Price { get; set; }
    }*/
}
