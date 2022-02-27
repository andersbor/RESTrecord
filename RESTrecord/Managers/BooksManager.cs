using System.Collections.Generic;
using RESTrecord.Models;

namespace RESTrecord.Managers
{
    public class BooksManager
    {
        private static int _nextId = 1;

        private static readonly List<IBook> Data = new List<IBook>()
        {
            new Book() {Id = _nextId++, Author = "Anders B", Title ="Big Ideas", Price = 14},
            new Book() {Id = _nextId++, Author = "Anders B", Title ="Even Larger Ideas", Price = 15}
        };

        public IEnumerable<IBook> GetAll()
        {
            return Data;
        }

        public IBook Add(Book value)
        {
            value.Id = _nextId++;
            Data.Add(value);
            return value;
        }
    }
}
